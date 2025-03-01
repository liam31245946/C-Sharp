// using System;

// namespace MyNameSpace{
//     public class MyApp{
//         public static void Main(){
//             Console.WriteLine("Hello");
//         }
//     }
// } 

var p1 = new Person("Liam", "Nguyen", new DateOnly(2000,1,1));

//car 
var c1 = new Car("Honda", "HR-V", 2025);

public class Person{

    public Person(string first, string last, DateOnly bd){

        firstName = first;
        lastName = last;
        birthDay = bd;
    }

    private string firstName;

    private string lastName;

    private DateOnly birthDay;
}

// another way 


public class Car(string brand, string model, int year) {

    public string brand { get;} = brand;
    public string model{ get;} = model;
    public int year { get;} = year;
}