



public class ClassesAndProperties
{
    //Properties
    public string? Name { get; set; } //Auto-implemented property

    //Field
    private int age = 10;

    //Constructor
    public ClassesAndProperties(string? name)
    {
        Name = name;
    }

    /*     public ClassesAndProperties() //<-- Dette er en constructor overload
        {
        } */

    public ClassesAndProperties() : this("Jørgen") //Chained constructor (Kalder den anden constructor og smider "Jørgen" ind som parameter)
    {
    }

    public string? name2
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    private string? _name;

}

