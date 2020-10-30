using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ensyu7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 7-1
            //var text = "Cozy lummox gives smart squid who asks for job pen";
            //Exercize1_1(text);
            #endregion

            #region 7-2
            // コンストラクタ呼び出し
            var abbrs = new Abbreviations();

            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            //問題7-2-3
            //Countプロパティを呼び出して数を出力させる
            Console.WriteLine(abbrs.Count);

            //Removeメソッドを呼び出して要素を削除する
            if (abbrs.Remove("NPT"))
                Console.WriteLine("削除成功");
        
            else
                Console.WriteLine("削除失敗");

            // インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names)
            {
                var fullname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}は見つかりません", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();

            // ToAbbreviationメソッドの利用例
            var japanese = "東南アジア諸国連合";
            var abbreviation = abbrs.ToAbbreviation(japanese);
            if (abbreviation == null)
                Console.WriteLine("{0} は見つかりません", japanese);
            else
                Console.WriteLine("「{0}」の略語は {1} です", japanese, abbreviation);
            Console.WriteLine();

            // FindAllメソッドの利用例
            foreach (var item in abbrs.FindAll("国際"))
            {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();
            
            abbrs.Where(x=>x.Key.Len)

            #endregion
        }


        #region 7-1-1    
        //private static void Exercize1_1(string text)
        //{
        //    Console.WriteLine("問題7-1-1");
        //    var dict = new Dictionary<char, int>();    //char→文字・int→数える

        //    foreach (var ch in text)
        //    {
        //        char upc = char.ToUpper(ch);

        //        if ('A' <= upc && upc <= 'Z')
        //        {
        //            //Keyに存在するか？
        //            if (dict.ContainsKey(upc))
        //            {
        //                //既に登録済み
        //                dict[upc]++;
        //            }

        //            //単語をKeyへ登録してValueに１を設定
        //            else
        //            {
        //                //未登録
        //                dict.Add(upc, 1);
        //            }
        //        }
        //    }

        //    //順番に表示
        //    foreach (var item in dict.OrderBy(x=>x.Key))
        //    {
        //        Console.WriteLine($"{item.Key} : {item.Value}");
        //    }

        //}
        #endregion
    }
}
