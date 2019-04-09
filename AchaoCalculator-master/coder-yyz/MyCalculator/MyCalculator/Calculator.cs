using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

public class Calculator 
{
    private static string[] op = new string[] { "+", "-", "×", "÷" }; //初始化运算符
    public static void Main(string[] args)
    {
       
        Console.WriteLine("请选择难度（输入1为一年级，输入2为二年级，输入3为三年级,生成时间较久！");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("请输入要生成的题数：");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string question = Makequestion();
            Console.WriteLine(question + "=");



            //string a = Solve(question);
            //Console.WriteLine("=" + a);

        }
        Console.Read();
    }
   
    //生成表达式
    public static string Makequestion()
    {
        Random r = new Random(Guid.NewGuid().GetHashCode());//解决随机数重复的问题
        StringBuilder build = new StringBuilder();
        int count = r.Next(0,1); // 运算符个数
        int start = 0;
        int number1 = r.Next(1,100);
        build.Append(number1);
        while (start <= count)
        {
            int operation = r.Next(0,2); // 随机运算符
            int number2 = r.Next(1,10);
            build.Append(op[operation]).Append(number2);
            start++;
        }
        return build.ToString();
    }
     
    //计算四则运算表达式结果
    public static string Solve(string question)
    {
        DataTable dt = new DataTable();
        string answer = dt.Compute(question, null).ToString();
        return answer;

    }
}
