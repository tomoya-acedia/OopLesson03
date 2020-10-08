using Chapter06;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region P.163まで
            //var numbers = Enumerable.Range(1, 20).ToArray();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region P.175
            //var numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, 8, -1, 6, 4, };
            //Console.WriteLine($"平均値：{numbers.Average()}");
            //Console.WriteLine($"合計値：{numbers.Sum()}");
            //Console.WriteLine($"最小値：{numbers.Where(n => n > 0).Min()}");
            //Console.WriteLine($"最大値：{numbers.Min()}");

            ////7の倍数があるのか
            //bool exists = numbers.Any(n => n % 7 == 0);

            //var results = numbers.Where(n => n > 0).Take(3);

            //foreach (var result in results)
            //{
            //    Console.Write(result + " ");
            //}

            //Console.WriteLine("\n-----------------------------");
            //var books = Books.GetBooks();
            //Console.WriteLine($"本の平均価格：{books.Average(x => x.Price)}");
            //Console.WriteLine($"本の合計価格：{books.Sum(x => x.Price)}");
            //Console.WriteLine($"本のページが最大：{books.Max(x => x.Pages)}");
            //Console.WriteLine($"高価な本：{books.Max(x => x.Price)}");
            //Console.WriteLine($"タイトルに「物語」がある冊数：{books.Count(x => x.Title.Contains("物語"))}");

            ////600ページを超える書籍があるか？(Anyメソッド)
            ////if (books.Any(n => n.Pages > 600))
            ////{
            ////    Console.WriteLine("存在する");
            ////}
            //Console.Write("600ページを超える書籍は");
            //Console.WriteLine(books.Any(x => x.Pages > 600) ? "ある" : "ない");


            ////すべてが200ページ以上の書籍化？(Allメソッド)
            ////if (books.All(n=>n.Pages>=200))
            ////{
            ////    Console.WriteLine("すべて200ページ以上です");
            ////}
            //Console.WriteLine();//改行
            //Console.Write("600ページを超える書籍は");
            //Console.WriteLine(books.All(x => x.Pages >= 200) ? "あります" : "ありません");

            ////400ページを超える本は何冊か？(FirstOrDefaultメソッド)
            //Console.WriteLine();//改行
            ////var book = books.FirstOrDefault(x => x.Pages > 400);
            ////int i;
            ////for (i = 0; i < books.Count; i++)
            ////{
            ////    if (books[i].Title.Contains(book.Title))
            ////    {
            ////        break;
            ////    }
            ////}
            //var count = books.FindIndex(x => x.Pages > 400);
            ////Console.WriteLine($"400ページを超える本は{i + 1}冊目です");
            //Console.WriteLine($"400ページを超える本は{count + 1}冊目です");


            ////本の値段が400円以上のものを3冊表示
            //Console.WriteLine();//改行

            //Console.WriteLine("本の値段が400円以上は");
            //var rt = books.Where(n => n.Price >= 400).Take(3);
            //foreach (var item in rt)
            //{
            //    Console.WriteLine(item.Title);
            //}
            #endregion

            //整数の例
            var numbers = new List<int>
            {
                19,17,15,24,12,25,14,20,12,28,19,30,24
            };
    
            //var strings = numbers.Select(n => n.ToString("0000")).ToArray();
            var strings = numbers.Distinct().ToArray();
            foreach (var str in strings)
            {
                Console.Write(str + " ");
            }
            numbers.Select(n => n.ToString("0000")).ToList().ForEach(s => Console.Write(s + " "));

            //並べ替え
            Console.WriteLine();
            var sortedNumbers = numbers.OrderBy(n => n);
            foreach (var nums in sortedNumbers)
            {
                Console.WriteLine(nums + " ");
            }

            //文字列の例
            Console.WriteLine("\n\n-----------------------");
            var words = new List<string>
            {
                "Microsoft","Apple","Google","Oracle","Facebook",
            };

            var lower = words.Select(x => x.ToLower()).ToArray();

            //オブジェクトの例
            Console.WriteLine("\n\n-----------------------");
            var books = Books.GetBooks();

            //タイトルのみのリスト
            var titles = books.Select(name => name.Title);

            foreach (var title in titles)
            {
                Console.Write(titles + " ");
            }
            Console.WriteLine("\n\n-----------------------");

            //ページの多い順に並べ替え(または金額の高い順)
            var sortedBooks = books.OrderByDescending(book => book.Pages);
            foreach (var book in sortedBooks)
            {
                Console.WriteLine(book.Title + " " + book.Pages);
            }
        }
    }
}
