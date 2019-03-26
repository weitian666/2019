using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = default(string);
            Console.WriteLine("Input:");
            string input = Console.ReadLine();
            try
            {
                double inputnum = Convert.ToDouble(input);
                string[] array = inputnum.ToString().Split('.');
      
                int num = Convert.ToInt32(Math.Pow(8, len));
                int value = Convert.ToInt32(inputnum * num);
                int a = value;
                int b = num;
                while (a != b)
                {
                    if (a < b)
                        a = a - b;
                    else
                        b = b - a;
                }
                value = value / a;
                num = num / a;

                result = string.Format("{0}/{1}", value, num);
            }
            catch (Exception)
            {
                result = input.ToString();
            }

            Console.WriteLine("Result:{0}", result);
            Console.ReadLine();      
        }
    }
}
 