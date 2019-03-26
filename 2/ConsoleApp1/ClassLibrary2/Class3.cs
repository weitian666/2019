using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class3
    {
        #region 生成题目的逻辑
        //生成四年级题目
        public static string topicfour(int scope)
        {
            string ret;
            ret = Class1.integer(scope) + " " + Class1.operators() + " " + Class1.integer(scope) + " " + Class1.operators() + " " + Class1.integer(scope);
            return ret;
        }
        //生成五年级题目
        public static string topicfive(int scope)
        {
            string ret;
            ret = Class1.decimals(scope) + " " + Class1.operators() + " " + Class1.decimals(scope) + " " + Class1.operators() + " " + Class1.decimals(scope);
            return ret;
        }
        //生成六年级题目
        public static string topicssix(int scope)
        {
            string ret;
            ret = Class1.grade(scope) + " " + Class1.operators() + " " + Class1.grade(scope) + " " + Class1.operators() + " " + Class1.grade(scope);
            return ret;
        }
        //生成混合题目
        public static string mixture(int scope)
        {
            string ret = "";
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                switch (random.Next(1, 4))
                {
                    case 1:
                        ret += Class1.integer(scope);
                        break;
                    case 2:
                        ret += Class1.decimals(scope);
                        break;
                    case 3:
                        ret += Class1.grade(scope);
                        break;
                }
                if (i != 2)
                {
                    ret += Class1.operators();
                }
            }
            return ret;
        }
        #endregion
    }
}
