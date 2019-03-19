using System;

namespace ElementaryArithmetic
{
    class Program
    {
        
      
        static void Main(string[] args)
        {

            int ans = 0;
            for (int i = 1; i < 11; i++)
            {
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                int f = rand.Next(1, 5);
                int a = rand.Next(1, 10);
                int b = rand.Next(1, 10);
               

                int c;
                switch (f)
                {
                    case 1:
                        Console.Write("{0}、  {1}+{2}-{0}×{1}÷{0}=", i, a, b,f);
                        c = Convert.ToInt32(Console.ReadLine());
                        if (c == a + b)
                        { Console.WriteLine("   T"); ans += 10; }
                        else
                            Console.WriteLine("   F");
                        break;
                    case 2:
                        Console.Write("{0}、  {1}+{2}-{0}×{1}÷{0}=", i, a, b);
                        c = Convert.ToInt32(Console.ReadLine());
                        if (c == a - b)
                        { Console.WriteLine("   T"); ans += 10; }
                        else
                            Console.WriteLine("   F");
                        break;
                    case 3:
                        Console.Write("{0}、{1}+{2}-{0}×{1}÷{0}=", i, a, b);
                        c = Convert.ToInt32(Console.ReadLine());
                        if (c == a * b)
                        { Console.WriteLine("   T"); ans += 10; }
                        else
                            Console.WriteLine("   F");
                        break;
                    case 4:
                        Console.Write("{0}、 {1}+{2}-{0}×{1}÷{0}=", i, a, b);
                        string str = (Console.ReadLine());
                        float d = float.Parse(str);//若+-*输入小数报错，也可使用这方法避免程序停止
                        if (d == ((float)a / b))
                        { Console.WriteLine("   T"); ans += 10; }
                        else
                            Console.WriteLine("   F");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("得分：{0}", ans);
        }

    }
}