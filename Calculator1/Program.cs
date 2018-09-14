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
        {   //develop branch
            double first_v;
            double second_v;
            double operation;
            int c;
            Console.WriteLine("Let start");
            for (;;)
            {
                {
                    Console.WriteLine("enter the first number");
                    first_v = Convert.ToDouble(Console.ReadLine());//convert to double
                    Console.WriteLine("enter the second number");
                    second_v = Convert.ToDouble(Console.ReadLine());
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
                            operation = first_v + second_v;
                            Console.WriteLine("a+b=" + operation);
                            break;
                        case 2:
                            operation = first_v - second_v;//
                            Console.WriteLine("a-b=" + operation);
                            break;
                        case 3:
                            operation = first_v * second_v;
                            Console.WriteLine("a*b=" + operation);
                            break;
                        case 4:
                            operation = first_v / second_v;
                            if (second_v == 0) { Console.WriteLine("You can't divide by zero. Try it one more time."); break; }
                            else
                                Console.WriteLine("a/b=" + operation);
                            break;
                        case 5:
                            Console.WriteLine("Exit from this cycle");
                            break;
                    }
                }
            }
        }
    }
}

