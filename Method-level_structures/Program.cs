public class Program
{
    public static void Main()
    {
        //Value type vs Reference type
        MethodHandling mh = new MethodHandling();
        mh.RefValueObjects();

        //Metode med optional attribut
        Attributes a = new Attributes();
        int aNumber = a.AttributesAnnotations(10);
        int b = a.AttributesAnnotations(10, 20);
        Console.WriteLine($"aNumber = {aNumber}, b = {b}");

        //Metode med params attribut
        int sum = a.AddNumbers(1, 2, 3, 4, 5);
        Console.WriteLine($"sum = {sum}");

        //Data Validation
        a.Age = 1000;
        bool isValid = a.Validate(a);
        Console.WriteLine($"isValid = {isValid}");
    }
}