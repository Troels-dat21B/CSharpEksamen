
public class ArrayShow
{


    public void showArray()
    {
        //Oprettelse
        int[] oddNumbers = new int[5]; //Angivet størelse
        int[] anotherNumbers = new int[5] { 1, 2, 3, 4, 5 }; //Angivet størelse og oprettelse
        int[] thirdNumbers = { 1, 2, 3, 4, 5 }; //Oprettelse uden type

        //Iterations###
        for (int i = 0; i < oddNumbers.Length; i++)
        {
            oddNumbers[i] = oddNumbers[i] + 10;
        }

        foreach (var numbers in oddNumbers)
        {
            Console.WriteLine($"dette nr. er {numbers}");
        }
        //####

        //IEnumerables metoder
        Console.WriteLine(anotherNumbers.Max()); //Returnere det højeste tal
        Console.WriteLine(anotherNumbers.Min()); // Returnere det mindste tal
        Console.WriteLine(anotherNumbers.Sum()); // Returnere summen af alle tal
        Console.WriteLine(anotherNumbers.Average()); // Returnere gennemsnits tallet
    }

    //MultiDimensional Arrays
    public void JaggedArrays()
    {

        //Oprettelse
        int[][] jaggedArray ={
            new int[] {1,3,5,7,9},
            new int[] {0,2,4,6},
            new int[] {11,22}
        };
        Console.WriteLine($"Første nr. er: {jaggedArray[0][0]}");

        //Går ind i det første array
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            //Går ind i det andet array og printer alle tal
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.WriteLine($"Tal: {jaggedArray[i][j]}");
            }
        }

        //Fixed multidimensional array 

        int[,] multiArray = {
            {1,2},
            {3,4},
            //{5,6,7} <-- Kan ikke lade sig gøre da det er fixed til 2
        };
        Console.WriteLine($"Første nr. er: {multiArray[0, 0]}");


    }


    public void IndexesShow(){
        int[] numbers = {1,2,3,4,5,6,7,8,9,10};
        //'From-end operator' == '^'
        Console.WriteLine(numbers[0]); //1
        Console.WriteLine(numbers[^1]); //10
        Console.WriteLine(numbers[^2]); //9
        Console.WriteLine(numbers[^3]); //8
        Console.WriteLine(numbers[^4]); //7
        Console.WriteLine(numbers[^5]); //6
        Console.WriteLine(numbers[^6]); //5
        Console.WriteLine(numbers[^7]); //4
        Console.WriteLine(numbers[^8]); //3
        Console.WriteLine(numbers[^9]); //2
        Console.WriteLine(numbers[^10]); //1
    }

    public void RangesShow(){

        int[] numbers = {1,2,3,4,5,6,7,8,9,10};
        //Bruger '..' til at lave en range
        //Ekskludere det sidste tal
        Range range = 1..4; //1,2,3

        //Kan kobineres med from-end operator
        Range range2 = ..^3; //1,2,3,4,5,6,7
        int[] rangeArray = numbers[range2]; //1,2,3,4,5,6,7

        foreach (var number in rangeArray)
        {
            Console.Write(number);
        }

    }


    

}