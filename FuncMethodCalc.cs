using System;

namespace FuncMethodCalc
{
    class Program
    {
        static void Calc(Func<int, int, int>input)
        {
            Console.WriteLine(input(20,5));
        }

        static void Main(string[] args)
        {
            var addFunc = new Func<int, int, int>(Add);
            Calc(addFunc);

            var diffFunc = new Func<int, int, int>(Sub);
            Calc(diffFunc);

            var mulFunc = new Func<int, int, int>(Mul);
            Calc(mulFunc);

            var divFunc = new Func<int, int, int>(Div);
            Calc(divFunc);
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
