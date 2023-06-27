


using System.Security.Cryptography.X509Certificates;

public class ClassesAndInheritance
{

    public string? Name { get; set; } //Auto-implemented property

    //Constructor
    public ClassesAndInheritance(string? name)
    {
        Name = name;
    }

    /*     public ClassesAndProperties() //<-- Dette er en constructor overload
        {
        } */

    public ClassesAndInheritance() : this("Jørgen") //Chained constructor (Kalder den anden constructor og smider "Jørgen" ind som parameter)
    {
    }
}

public struct Structs //Kan ikke arve fra structs
{
    public int value;

}

public record Records
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

sealed class SealedClass 
{
    //Kan ikke arve fra SealedClass.
    //En måde at beskytte klassen fra andre udvikler, så de ikke kan arve fra den eller modificere indholdet i den.
}

partial class PartialClass
{
    //Kan deles op i flere filer
    //Bliver samlet som en enkel klasse når den bliver compiled i run time
}