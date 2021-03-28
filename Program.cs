using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            x = a;
            y = b;

            do
            {
                if (x == y)
                {
                    Console.WriteLine(x); break;
                }
                else
                {
                    if (x < y)
                    { x = x + a; } 
                    else
                    { y = y + b; }
                    break;
                }
            }
            while (x == y);
            Console.WriteLine(x);         

            

           
        }
    }
}
