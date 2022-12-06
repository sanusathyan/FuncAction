using System;

namespace ActionCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var addAction = new Action<int, int>(Add);
            addAction(20,10);

            var diffAction = new Action<int, int>(Sub);
            diffAction(20, 10);

            var mulAction = new Action<int, int>(Mul);
            mulAction(20, 10);

            var divAction = new Action<int, int>(Div);
            divAction(20, 10);
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
