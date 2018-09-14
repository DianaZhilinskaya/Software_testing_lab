using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double d;
            int c;
            for (;;)
            {
                {
                    Console.WriteLine("enter the first number");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter the second number");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choose the operation");
                    Console.WriteLine("1)+");
                    Console.WriteLine("2)-");
                    Console.WriteLine("3)*");
                    Console.WriteLine("4)/");
                    Console.WriteLine("5)exit");
                    c = Convert.ToInt16(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            d = a + b;
                            Console.WriteLine("a+b=" + d);
                            break;
                        case 2:
                            d = a - b;
                            Console.WriteLine("a-b=" + d);
                            break;
                        case 3:
                            d = a * b;
                            Console.WriteLine("a*b=" + d);
                            break;
                        case 4:
                            d = a / b;
                            if (a == 0) { Console.WriteLine("You can't divide by zero. Try it one more time."); break; }
                            else
                                Console.WriteLine("a/b=" + d);
                            break;
                        case 5:
                            d = a / b;
                            Console.WriteLine("a/b=" + d);
                            break;
                    }
                }
            }
        }
    }
}

