using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle1
{
    public class Triangle
    {
        public bool test(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a != null && b != null && c != null)
                {
                    if (a + b <= c || a + c <= b || b + c <= a)
                    {
                        return false;
                    }

                    return true;
                }
                return true;
            }

            else { Console.WriteLine("This can not be."); return false; }

        }
    }
}
