using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensyu3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 問題3-1-1
            //Console.WriteLine("問題3-1-1");

            //var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            //var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);

            ////Console.WriteLine(exists);
            //if (exists == true)
            //{
            //    Console.WriteLine("存在する");
            //}
            //else
            //{
            //    Console.WriteLine("存在しない");
            //}

            //Console.WriteLine("");

            #endregion

            #region 問題3-1-2
            //Console.WriteLine("問題3-1-2");
            //numbers.ForEach(s => Console.WriteLine(s / 2.0));

            //Console.WriteLine("");

            //先生の回答
            //var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            //numbers.ForEach(s => Console.WriteLine(s / 2.0));
            #endregion

            #region 問題3-1-3
            //Console.WriteLine("問題3-1-3");
            //var num = numbers.Where(s => s >= 50);
            //foreach (var item in num)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("");


            //先生の回答
            //var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            //numbers.Where(x => x >= 50).ToList().ForEach(Console.WriteLine);
            #endregion

            #region 問題3-1-4
            //Console.WriteLine("問題3-1-4");

            ////遅延実行(リストにしてからでないと、リストに格納できない)
            //List<int>  number = numbers.Select(s => s * 2).ToList();

            ////var number = numbers.Select(s => s * 2);
            //foreach (var item in number)
            //{
            //    Console.WriteLine(item);
            //}


            //先生の回答
            //var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            //numbers.Select(x => x * 2).ToList().ForEach(Console.WriteLine);
            #endregion

            #region 問題3-2-1
            //var names = new List<string>
            //{
            //    "Tokyo","New Delhi","Bankok","London","Parlis","Berlin","Canbera","Hong Kong",
            //};

            //while(true)
            //{
            //var line = Console.ReadLine();

            //var ans = names.FindIndex(s => s == line);

            //Console.WriteLine(ans);

            //if (line == "")
            //{
            //    break;
            //}

            //else
            //{
            //    Console.WriteLine("-1");
            //    break;
            //}
            //}

            //先生の回答
            //Console.WriteLine();//改行
            //Console.WriteLine("問題");
            //Console.WriteLine("都市名を入力空行終了");

            //do
            //{
            //    var line = Console.ReadLine();
            //    //『null』または『空』だったらtrueを返す
            //    if (string.IsNullOrEmpty(line))
            //    {
            //        break;
            //    }
            //    var index = names.FindIndex(s => s == line);
            //} 
            //while (true);

            #endregion

            #region 問題3-2-2
            //var names = new List<string>
            //{
            //    "Tokyo","New Delhi","Bankok","London","Parlis","Berlin","Canbera","Hong Kong",
            //};

            //var ans = names.Count(s => s.Contains("o"));

            //Console.WriteLine(ans);


            //先生の回答
            //Console.WriteLine();//改行
            //Console.WriteLine("問題");
            //var count = names.Count(s => s.Contains('o');
            //Console.WriteLine(count);
            #endregion

            #region 問題3-2-3
            //var names = new List<string>
            //{
            //    "Tokyo","New Delhi","Bankok","London","Parlis","Berlin","Canbera","Hong Kong",
            //};

            //var ans = names.Where(s => s.Contains("o")).ToArray();

            //foreach (var item in ans)
            //{
            //    Console.WriteLine(item);
            //}


            //先生の回答
            //Console.WriteLine();//改行
            //Console.WriteLine("問題");
            //var selected = names.Where(s => s.Contains('o')).ToArray();
            //foreach (var item in selected)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 問題3-2-4
            //var names = new List<string>
            //{
            //    "Tokyo","New Delhi","Bangkok","London","Parlis","Berlin","Canbera","Hong Kong",
            //};

            //var ans = names.Where(s => s.Contains("B")).ToArray();
            //var ans2 = ans.Select(s => s.Length);

            //foreach (var item in ans2)
            //{
            //    Console.WriteLine(item);
            //}


            //先生の回答
            //Console.WriteLine();//改行
            //Console.WriteLine("問題");
            //var names = new List<string>
            //{
            //    "Tokyo","New Delhi","Bangkok","London","Parlis","Berlin","Canbera","Hong Kong",
            //};
            ////文字列の先頭が『B』のとき
            //var nameCount = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            //foreach (var item in nameCount)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
