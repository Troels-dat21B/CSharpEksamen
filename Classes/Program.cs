

public class Classes{


    public static void Main(){
    
    //Polymorphism
    //Static method dispatch
    Animal animal = new Cat();
    animal.MakeSound();
    Animal animal2 = new Dog();
    animal2.MakeSound();

    //Classes and properties
    ClassesAndProperties classesAndProperties = new ClassesAndProperties("Hello");// Object initialization
    ClassesAndProperties classesAndProperties2 = new ClassesAndProperties();// Object initialization (Bruger den tomme constructor)

    //Structs
    Structs structs = new Structs() {value = 1}; //'Value' refferere til et field i Structen


    //Records
    Records records = new Records() {Name = "Hello", Age = 1}; //'Name' og 'Age' refferere til properties i Recorden
    Console.WriteLine(records); //ToString() er overridet i Records, så den printer propertiesne ud. Built-in feature i C# 9.0

    //Inheritance
    


    }

}