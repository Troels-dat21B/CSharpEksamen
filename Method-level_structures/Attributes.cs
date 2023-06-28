using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class Attributes
{


    //Attributes er metadata omkring en klasse, metode, property, parameter, osv.
    //Bruges for at validere data, eller til at tilføje ekstra funktionalitet til en klasse/metode
    [Range(0, 100)]//<--- indbygget attribute i C#
    public int Age { get; set; }

    [EmailAddress]//<--- indbygget attribute i C#
    public string? Email { get; set; }

    [Phone]//<--- indbygget attribute i C#
    int PhoneNumber { get; set; }

    

    public int AttributesAnnotations(int x, [Optional] int y)
    {
        return x + y;
    }

    public int AddNumbers(params int[] numbers){//Params indtager et array af værdier. Skal være det sidste parameterlisten
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    //Validerer en Object ud fra de angivne attributter
    public bool Validate(Attributes a){
        
        var results = new List<ValidationResult>();
        var context = new ValidationContext(a);

        return Validator.TryValidateObject(this, context, results, true);
    }




}