using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("b1: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("k1: ");
            double k1 = double.Parse(Console.ReadLine());
            Console.Write("b2: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("k2: ");
            double k2 = double.Parse(Console.ReadLine());
            if (k1 == k2 && b1 == b2)
            {
                Console.WriteLine("Прямые совпадают");
            }
            else
            {
                if (k1 == k2)
                {
                    Console.Write("Прямые параллельны");
                }
                else
                {
                    double x = (b2 - b1) / (k1 - k2);
                    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
                    Console.WriteLine("({0:0.0}; {1:0.0})", x, y);                    
                }
            }
            Console.ReadKey();
        }
    }
}