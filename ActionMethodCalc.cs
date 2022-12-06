using System;

namespace ActionMethodCalc
{
    class Program
    {
        static void Calc(Action<int, int> input)
        {
            input(100,50);
        }

        static void Main(string[] args)
        {
            var addAction = new Action<int, int>(Add);
            Calc(addAction);

            var diffAction = new Action<int, int>(Sub);
            Calc(diffAction);

            var mulAction = new Action<int, int>(Mul);
            Calc(mulAction);

            var divAction = new Action<int, int>(Div);
            Calc(divAction);
        }

        static void Add(int firstnum, int secondnum)
        {
            Console.WriteLine(firstnum + secondnum);
        }

        static void Sub(int firstnum, int secondnum)
        {
            Console.WriteLine(firstnum - secondnum);
        }

        static void Mul(int firstnum, int secondnum)
        {
            Console.WriteLine(firstnum * secondnum);
        }

        static void Div(int firstnum, int secondnum)
        {
            Console.WriteLine(firstnum / secondnum);
        }
    }
}
