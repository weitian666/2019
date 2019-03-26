using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        #region 生成数与符号
        //随机整数
        public static string integer(int scope)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(1, scope).ToString();
        }
        //随机小数
        public static string decimals(int scope)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(1, scope).ToString() + "." + random.Next(1, 10);
        }
        //随机分数
        public static string grade(int scope)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(1, scope).ToString() + "/" + random.Next(1, 10);
        }
        //随机运算符      
        public static string operators()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            

            switch (random.Next(1, 5))
            {
                case 1:
                    return "＋";
                case 2:
                    return "－";
                case 3:
                    return "×";
                case 4:
                    return "÷";
            }
            return "";
        }
        //括号
        public static void bracket()
        {

        }
        #endregion
    }
}
