




class Animal
{
    public virtual void MakeSound() //Virtuel metode, som kan overrides af medtoder der bruger keyworded "override"
    {
        Console.WriteLine("Generic animal sound");
    }
}

class Cat : Animal
{
    public override void MakeSound() //Overrider den virtuelle metode i Animal
    {
        Console.WriteLine("Meow");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}



