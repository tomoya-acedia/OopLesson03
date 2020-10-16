using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensyu7
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            
            #region 7-1
            Exercize1_1(text);
            #endregion

            #region 7-2
            #endregion
        }


        #region 7-1-1    
        private static void Exercize1_1(string text)
        {
            Console.WriteLine("問題7-1-1");
            var dict = new Dictionary<char, int>();    //char→文字・int→数える

            foreach (var ch in text)
            {
                char upc = char.ToUpper(ch);

                if ('A' <= upc && upc <= 'Z')
                {
                    //Keyに存在するか？
                    if (dict.ContainsKey(upc))
                    {
                        //既に登録済み
                        dict[upc]++;
                    }

                    //単語をKeyへ登録してValueに１を設定
                    else
                    {
                        //未登録
                        dict.Add(upc, 1);
                    }
                }
            }

            //順番に表示
            foreach (var item in dict.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
        #endregion
    }
}
