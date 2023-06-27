
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class Abstraction : IShowInterface, IShowInterfaceCopy
{

    public static void Main()
    {
        //Lambdas expression
        var x = (int num) => num + 5;

        //Lambdas Statement
        var y = (int a, int b) =>{
            var sum = a + b;
            return sum;
        };
        
    }


    //#######Interfaces
    //Implicit
    public int ShowThisInt()
    {
        return 1;

    }

    //Explicit 
    int IShowInterfaceCopy.ShowThisInt()
    {
        return 2;
    }

    //##########

public static void DelegateMethod(string msg){
    Console.WriteLine(msg);
}


Delegate handler = DelegateMethod;



}
