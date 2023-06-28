public class AsyncAwait{




    //Begge metoder er implicit asynkrone, da de bruger Async keywordet.
    //Da Taskens Type er int, kan den parse til en int.
    public async Task<int> GetNumberAsync(){
        await Task.Delay(1000);
        return 5;
    }

    public async Task GetNumberAsync2(){
        await Task.Delay(1000);
        Console.WriteLine("Done");
    }


    //Denne metode er eksplicit asynkronsk, da jeg fortæller den, at den skal køre på en anden tråd. med Task.run
    //Bruger Lambda expression til at fortælle den, hvad den skal gøre.
    public Task<int> GetNumberAsync3(){
        return Task.Run(() => {
            Thread.Sleep(1000);
            return 5;
        });
    }
}