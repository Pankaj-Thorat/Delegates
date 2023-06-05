using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class MultiCastDelegates
    { 
        delegate void DelOp(int x, int y);

        public static void MulticastDelegate()
        {
            //Delegate Instantiation
            DelOp obj = Operation.Addition;
            obj += Operation.Square;

            obj(5, 5);
            obj(6, 8);
        }

    }

    public class Operation
    {
        public static void Addition(int x,int y)
        {
            Console.WriteLine($"Addition of {x} and {y} by MultiCasting is {x + y}");
        }
        
        public static void Square(int x,int y)
        {
            Console.WriteLine($"Multiple of {x} and {y} by MultiCasting is {x * y}");
        }
    }
}
