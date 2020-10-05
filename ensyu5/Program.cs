using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensyu5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 5-1
            //Console.WriteLine("--5.1--");
            //Console.Write("文字１：");
            //var str1 = Console.ReadLine();
            //Console.Write("文字２：");
            //var str2 = Console.ReadLine();

            //if (String.Compare(str1, str2, true) == 0)
            //{
            //    Console.WriteLine("等しい");
            //}
            //else
            //{
            //    Console.WriteLine("等しくない");
            //}

            //Console.WriteLine("");//改行
            #endregion

            #region 5-2
            //5-2
            //Console.WriteLine("--5.2--");
            //var line = Console.ReadLine();
            //int num;
            //if (int.TryParse(line, out num))
            //{
            //    Console.WriteLine(num.ToString("#,0"));
            //}
            //else
            //{
            //    Console.WriteLine("数値文字列ではありません");
            //}

            //Console.WriteLine("");//改行
            #endregion

            #region 5-3-1
            //Console.WriteLine("--5.3.1--");
            //var str = new List<string>
            //{
            //    "Jackdaws Love my big sphinx of quartz"
            //};

            //foreach (var item in str)
            //{
            //    //var count = str.Count(s => s.Contains(" "));
            //    var count = item.Count(s => s == ' ');
            //    Console.WriteLine(count);
            //}


            #region 先生の回答
            //var text = "Jackdaws Love my big sphinx of quartz";
            //int spaces = text.Count(c => c == ' ');
            #endregion
            Console.WriteLine("");//改行
            #endregion
            #region 5-3-2
            //
            //Console.WriteLine("--5.3.2--");
            //foreach (var item in str)
            //{
            //    var replaced = item.Replace("big", "small");
            //    Console.WriteLine(replaced);
            //}
            #endregion
            #region 先生の回答
            //var text = "Jackdaws Love my big sphinx of quartz";
            //var replaced = text.Replace("big", "small");
            //Console.WriteLine(replaced);

            Console.WriteLine("");//改行
            #endregion
            //5-3-3
            Console.WriteLine("--5.3.3--");
            #region 先生の回答
            //var text = "Jackdaws Love my big sphinx of quartz";
            //var Count = text.Split(' ').Count();
            ////var Count = text.Split(' ').Length();
            //Console.WriteLine("単語数:{0}", Count);
            #endregion

            Console.WriteLine("");//改行


            //5-3-4
            Console.WriteLine("--5.3.4--");

            #region 先生の回答

            //var words = text.Split(' ').Where(s => s.Length <= 4);
            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            //1行の場合
            //text.Split(' ').Where(s => s.Length <= 4).ToList().ForEach(Console.WriteLine);
            #endregion

            Console.WriteLine("");//改行


            //5-3-5
            Console.WriteLine("--5.3.5--");

            #region 先生の回答
            //var array = text.Split(' ').ToArray();
            //if (array.Length > 0)
            //{
            //    var sb = new StringBuilder(array[0]);
            //    foreach (var word in array.Skip(1))
            //    {
            //        sb.Append(' ');
            //        sb.Append(word);
            //    }
            //    Console.WriteLine(sb);
            //}
            #endregion

            Console.WriteLine("");//改行


            //5-4
            Console.WriteLine("--5.4--");

            #region 先生の回答
            var text = "Jackdaws Love my big sphinx of quartz";
            var lines = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            
            foreach (var item in lines.Split(';'))
            {
                var word = item.Split('=');
                Console.WriteLine("{0}:{1}", ToJapanese(word[0]), word[1]);
            }

            #endregion
        }

        static string ToJapanese(string key)
        {
            switch (key)
            {
                case "Novelist":
                    return "作家";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";

                default:
                    return "     ";
            }
        }
    }
}
