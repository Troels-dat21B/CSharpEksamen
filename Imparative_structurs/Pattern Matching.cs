public class PatternMatching
{
    public static void Main()
    {
        //Pattern Matching
        object o = "Jørgen";
        if (o is string s)
        {
            Console.WriteLine(s);
        }
        else
        {
            Console.WriteLine("Not a string");
        }

        int m = 1;

        //Switch statement
        switch (m)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            default:
                Console.WriteLine("Other");
                break;
        }

        //Switch expression
        string str = m switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            _ => "Other"
        };

        //Switch statement med raltive patterns
        switch (m)
        {
            case 3: //fall through case, da der ikke er en "Break;"
            case > 10: //over 0
                Console.WriteLine("Positive");
                break;
            case < 0: //Mindre end 0
                Console.WriteLine("Negative");
                break;
            case >= 3 and < 10:
                Console.WriteLine("Between 3 and 10");
                break;
            default:
                Console.WriteLine("Zero");
                break;
        }

        //Switch statement med case guards
        switch (m)
        {
            //Case guards gør det muligt at lave cases med samme værdi, men med specifikke betingelser
            case > 0 when m % 2 == 0:
                Console.WriteLine("Positive even");
                break;
            case > 0 when m % 2 != 0:
                Console.WriteLine("Positive odd");
                break;
            case < 0:
                Console.WriteLine("Negative");
                break;
            default:
                Console.WriteLine("Zero");
                break;
        }


        //If statement. Mere fleksibelt end if Expressions
        if(m >0){
            //Do something
        }else{
            //Do something else
        }

        //if expression. God til simple one liners
        string str2 = m > 0 ? "Positive" : "Negative";
        //bruger ? og : til at lave en if statement i en expression. (Tunery operator)
    }
}