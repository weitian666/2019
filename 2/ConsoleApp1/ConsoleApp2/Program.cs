using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要生成的题数");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("请选择难度（输入1为一年级，整数运算，输入2为二年级，带有限小数运算，输入3为三年级,带分数运算)\n输入4混合运算，生成时间较久！");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算范围");
            int scope = int.Parse(Console.ReadLine());
            //int quantity = 10, num = 1, scope = 10;
            //生成试题 
           Class2.a(num,quantity,scope);
        }
    }
}
