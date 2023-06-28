public class Program
{
    public static void Main()
    {
        AsyncAwait aa = new AsyncAwait();

        //Tasken returnerer en værdi. Det kan parse til en simpelt int.
        //Det går vi her med .Result
        int result = aa.GetNumberAsync().Result;
        Console.WriteLine($"result = {result}");

        //Da tasken er asynkronsk og ikke returnerer en værdi. Kan vi bruge .Wait for at fortælle compileren, at den skal venter med at køre videre, indtil tasken er færdig.
        aa.GetNumberAsync2().Wait();

        //Skaber en continuation på tasken, så den kan køre videre.
        Task<int> task = aa.GetNumberAsync3();
        task.ContinueWith(t => {
            Console.WriteLine($"result = {t.Result}");
        });

        //Venter på at tasken er færdig.
        task.Wait();
    }
}