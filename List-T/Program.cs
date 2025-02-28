var names = new List<string>{"<name>", "Ana","Felipe"};

names.Add("David");
names.Add("Liam");

foreach (var name in names){
    Console.WriteLine($"Hello {name.ToUpper()}");
}

for (int i =0 ; i < names.Count; i++){
    Console.WriteLine($"Hello {names[i].ToUpper()}, this is second approach");
}