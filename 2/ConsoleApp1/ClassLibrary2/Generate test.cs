using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Collections;
using System.IO;

namespace ClassLibrary2
{
   public class Class2
    {
        //生成试题
        public static void a(int num, int quantity,int scope)
        {
            
            //利用哈希表进行数据的存储与查
            Hashtable fourOperations = new Hashtable();
            Console.WriteLine("正在生成题目,请稍等");
            switch (num)
            {
                case 1:
                    #region 四年级题目
                    for (int i = 0; i < quantity; i++)
                    {
                        string topic = (Class3.topicfour(scope));
                        string answer = (consequence(topic));
                        if (fourOperations.Contains(topic))
                        {
                            i--;
                            break;
                        }
                        if (Convert.ToDouble(answer) > 0)
                        {
                            fourOperations.Add(topic, answer);
                        }
                        else
                        {
                            i--;
                        }
                    }
                    break;
                #endregion
                case 2:
                    #region 五年级题目
                    for (int i = 0; i < quantity; i++)
                    {
                        string topic = (Class3.topicfive(scope));
                        string answer = (consequence(topic));
                        if (fourOperations.Contains(topic))
                        {
                            i--;
                            break;
                        }
                        if (Convert.ToDouble(answer) > 0)
                        {
                            fourOperations.Add(topic, answer);
                        }
                        else
                        {
                            i--;
                        }
                    }
                    break;
                #endregion
                case 3:
                    #region 六年级题目
                    for (int i = 0; i < quantity; i++)
                    {
                        Console.WriteLine(Class3.topicssix(scope));
                    }
                    break;
                #endregion
                case 4:
                    #region 混合运算题目
                    for (int i = 0; i < quantity; i++)
                    {
                        Console.WriteLine(Class3.mixture(scope));
                    }
                    #endregion
                    break;
            }
            #region 写入TXT
            //题目的TX
            FileStream fs = new FileStream("D:\\四则运算\\四则运算题目.txt", FileMode.Create);
            //答案的TXT
            FileStream da = new FileStream("D:\\四则运算\\四则运算的答案.txt", FileMode.Create);
            int plus = 1;
            foreach (string a in fourOperations.Keys)
            {
                //获得字节数组
                byte[] data = System.Text.Encoding.Default.GetBytes("第" + plus + "题." + a + " =" + "\r\n");
                //开始写入
                fs.Write(data, 0, data.Length);
                plus++;
            }
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
            plus = 1;
            foreach (string b in fourOperations.Values)
            {
                //获得字节数组
                byte[] data = System.Text.Encoding.Default.GetBytes("第" + plus + "题:" + b + "\r\n");
                //开始写入
                da.Write(data, 0, data.Length);
                plus++;
            }
            //清空缓冲区、关闭流
            da.Flush();
            da.Close();
            
            #endregion
            Console.WriteLine("生成完毕");
            Console.ReadKey();
        }

        //无分数结果验算
        public static string consequence(string equation)
        {  
            //小数与整数运算           
            string formula = equation.Replace("÷", "/");
            formula = formula.Replace("×", "*");
            formula = formula.Replace("＋", "+");
            formula = formula.Replace("－", "-");
            DataTable dt = new DataTable();
            string really_data = dt.Compute(formula, "false").ToString();
            return really_data;
           
        }
    }
}
