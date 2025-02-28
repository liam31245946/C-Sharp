﻿var fruits = new List <string>{"apple", "watermelon", "banana", "peach"};
var numbers = new List<int>{ 3,45,56,23,94,345,1324,53};


fruits.Sort();

numbers.Sort();


foreach (var fruit in fruits){
    Console.WriteLine($"Hello {fruit.ToUpper()}");
}

foreach (var number in numbers){
    Console.WriteLine(number);
}