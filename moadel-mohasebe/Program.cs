using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moadel_mohasebe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter midterm nomre: ");

            double x = Convert.ToInt32(Console.ReadLine());

            Console.Write("please enter nahaee nomre: ");

            double y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("nomre = {0}", calc(x, y));

            if (calc(x, y) >= 10)
            {
                Console.WriteLine("passed");
            }
            else
            {
                Console.WriteLine("not passed");
                Console.ReadKey();

            }
        }

        private static double calc(double x, double y)
        {
            double result = 0.35 * x + 0.65 * y;
            Console.ReadKey();
            return result;
        }
    }
}
