using System;

namespace Fibonachi
{
    class Program
    {
        static void Main()
        {
            try
            {
                int F, F1, F2,c,v,N;
                int counter;
                do
                {
                    Console.WriteLine("Введіть кількість елементів послідовності");
                    N = int.Parse(Console.ReadLine());
                }
                while (N <= 2);
                counter = 3;
                F1 = 1;
                F2 = 1;
                c = F1;
                v = F2;
                Console.WriteLine("Крок   Число");
                do
                {
                    F =c + v; 
                    Console.WriteLine("{0}        {1}", counter, F);
                    c = v;
                    v = F;
                    counter++;
                }
                while (counter <= N);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
