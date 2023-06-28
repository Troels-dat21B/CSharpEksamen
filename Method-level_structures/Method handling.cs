public class MethodHandling
{

    public void RefValueObjects()
    {
        //Value type. Repræsentere den akutelle værdi på stacken
        int x = 10;
        int y = x; //en kopi af værdien i x
        x = 20; //ændre x til en ny værdi. y beholder den gamle værdi
        Console.WriteLine($"x = {x}, y = {y}"); //x = 20, y = 10

        //Reference type. Repræsentere en reference til en værdi på heapen
        int[] a = { 1, 2, 3 };
        int[] b = a; //en reference til a
        a[0] = 10; //ændre a[0] til en ny værdi. b[0] ændres også
        Console.WriteLine($"a[0] = {a[0]}, b[0] = {b[0]}"); //a[0] = 10, b[0] = 10


        Test(x, out y, ref x);
        Console.WriteLine($"x = {x}, y = {y}"); //x = 10, y = 10
    }

    //In/Out/Ref bruges til at modificere værdier i metodens parameterliste
    //in = readonly. Kan ikke ændres i metoden
    //out = Forventes at få en værdi i metoden. Gør det muligt at returnere flere værdier
    //ref = Ændre på den direkte variabel udenfor metoden. Skal initialiseres før metoden kaldes
    public void Test(in int x, out int y, ref int z)
    {
        //x = 10; //fejl. x er readonly
        y = 100; //fejl. y er ikke initialiseret
        z = 50; //ok. z er initialiseret
    }
}