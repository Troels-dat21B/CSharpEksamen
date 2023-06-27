
namespace Namespace
{


    public class NullHandling
    {

        //Declaration of nullable types
        int? a = null;

        //Testing for null
        public void TestForNull()
        {
            if (a.HasValue)
            {
                Console.WriteLine("a is null");
            }
        }
        //Null value object
        public void NullValueObject()
        {
            int? c = null; //Reference type der er tildelt Null
        }

        //Null Coalescing Operator (??) = (or-else)
        public void NullCoalescingOperator()
        {
            int b = a ?? 0;
        }


    }
}