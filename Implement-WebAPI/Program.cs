using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var todos = new List<Todo>();

// Create
app.MapPost("/todos", (Todo task) =>
{
    todos.Add(task);
    return TypedResults.Created($"/todos/{task.Id}", task);
});

// Read one item
app.MapGet("/todos/{id}", Results<Ok<Todo>, NotFound> (int id) =>
{
    var targetTodo = todos.SingleOrDefault(t => t.Id == id);
    return targetTodo is null
        ? TypedResults.NotFound()
        : TypedResults.Ok(targetTodo);
});

// Read all
app.MapGet("/todos", () => todos);

// Update (PUT)
app.MapPut("/todos/{id}", Results<NoContent, NotFound> (int id, Todo updatedTodo) =>
{
    var index = todos.FindIndex(t => t.Id == id);
    if (index == -1)
        return TypedResults.NotFound();

    todos[index] = updatedTodo;
    return TypedResults.NoContent();
});

// Delete
app.MapDelete("/todos/{id}", Results<NoContent, NotFound> (int id) =>
{
    var targetTodo = todos.SingleOrDefault(t => t.Id == id);
    if (targetTodo is null)
        return TypedResults.NotFound();

    todos.Remove(targetTodo);
    return TypedResults.NoContent();
});

app.Run();

public record Todo(int Id, string Name, DateTime DueDate, bool IsCompleted);
