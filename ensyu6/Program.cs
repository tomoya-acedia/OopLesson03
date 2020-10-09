using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensyu6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            #region 6.1
            Console.WriteLine("問6.1.1");
            var max = numbers.Max();
            Console.WriteLine(max);
            #endregion

            #region 6.2
            Console.WriteLine("\n--------------------");
            Console.WriteLine("問6.1.2");
            int pos = numbers.Length - 2;
            foreach (var number in numbers.Skip(pos))
            {
                Console.Write(number+" ");
            }
            #endregion

            #region 6.3
            Console.WriteLine("\n--------------------");
            Console.WriteLine("問6.1.3");
            foreach (var item in numbers)
            {
                Console.Write(item.ToString() + " ");
            }

            //var strNums = numbers.Select(n => n.ToString("000"));
            //Console.WriteLine();
            //foreach (var str in strNums)
            //{
            //    Console.Write(str.ToString() + " ");
            //}

            #endregion

            #region 6.4
            Console.WriteLine("\n--------------------");
            Console.WriteLine("問6.1.4");
            var nums = numbers.OrderBy(n => n);
            foreach (var item in nums.Take(3))
            {
                Console.Write(item + " ");
            }

            //foreach (var item in numbers.OrderBy(n => n).Take(3))
            //{
            //    Console.Write(item + " ");
            //}


            #endregion

            #region 6.5
            Console.WriteLine("\n--------------------");
            Console.WriteLine("問6.1.5");
            Console.WriteLine(numbers.Distinct().Count(n => n >= 10));
            #endregion

            #region 6.2
            var books = new List<Book>
            {
                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
             };
            #endregion


            #region 6.2.1
            Console.WriteLine("\n--------------------");
            Console.WriteLine("問6.2.1");
            //foreach (var item in books.Where(n => n.Title == "ワンダフル・C#ライフ"))
            //{
            //    Console.Write("価格：" + item.Price + " " + "ページ：" + item.Pages);
            //}

            var book = books.FirstOrDefault(b => b.Title == "ワンダフル・C#ライフ");
            if (book != null)
            {
                Console.WriteLine($"{book.Price}{book.Pages}");
            }
            #endregion

            #region 6.2.2
            Console.WriteLine("\n--------------------");
            Console.WriteLine("問6.2.2");

            int count = books.Count(b => b.Title.Contains("C#"));
            Console.WriteLine(count);

            #endregion

            #region 6.2.3
            Console.WriteLine("\n--------------------");
            Console.WriteLine("問6.2.3");
            var average = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);
            Console.WriteLine(average);
            #endregion

            #region 6.2.4
            Console.WriteLine("\n--------------------");
            Console.WriteLine("問6.2.4");
            var bk = books.FirstOrDefault(b => b.Price >= 4000);
            if (bk!=null)
            {
                Console.WriteLine(bk.Title);
            }
            #endregion

            #region 6.2.5
            Console.WriteLine("\n--------------------");
            Console.WriteLine("問6.2.5");
            var pages = books.Where(b => b.Price < 4000).Max(b=>b.Pages);
            Console.WriteLine(pages);
            #endregion

            #region 6.2.6
            Console.WriteLine("\n--------------------");
            Console.WriteLine("問6.2.6");
            var selected = books.Where(b => b.Pages >= 400).OrderByDescending(b => b.Price);
            foreach (var item in selected)
            {
                Console.WriteLine("{0}{1}", book.Title, book.Price);
            }
            #endregion

            #region 6.2.7
            Console.WriteLine("\n--------------------");
            Console.WriteLine("問6.2.7");
            var st = books.Where(b => b.Title.Contains("C#") && b.Pages <= 500);
            foreach (var item in st)
            {
                Console.WriteLine(item.Title);
            }
            #endregion

        }
    }
}
