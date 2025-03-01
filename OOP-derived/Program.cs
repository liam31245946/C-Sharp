


public abstract class Pet(string firstName){
     public string First{get;} = firstName;
    public abstract string MakeNoise();
}


public class Cat(string firstName): Pet(firstName){
    
    public override string MakeNoise() => "meow";
}

public class Dog(string firstName) : Pet(firstName){
   
    public override string MakeNoise() => "bark";
}