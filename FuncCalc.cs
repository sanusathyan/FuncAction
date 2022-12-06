using System;

namespace FuncCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var addFunc = new Func<int, int, int>(Add);
            Console.WriteLine(addFunc(20,10));

            var diffFunc = new Func<int, int, int>(Sub);
            Console.WriteLine(diffFunc(20,10));

            var productFunc = new Func<int, int, int>(Mul);
            Console.WriteLine(productFunc(20, 10));

            var divisionFunc = new Func<int, int, int>(Div);
            Console.WriteLine(divisionFunc(20, 10));
        }

        static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        static int Sub(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        static int Mul(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        static int Div(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }
    }
}
