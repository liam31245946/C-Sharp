﻿var names = new List<string>{"<name>", "Ana","Felipe", "David", "Liam"};


foreach (var name in names[2..4]){
    Console.WriteLine($"Hello {name.ToUpper()}");
}

Console.WriteLine(names[0]);
Console.WriteLine(names[^2]);

﻿var fruits = new string[]{"apple", "watermelon", "banana", "peach"};

fruits = [.. fruits, "lychee"];

foreach (var fruit in fruits){
    Console.WriteLine($"Hello {fruit.ToUpper()}");
}
