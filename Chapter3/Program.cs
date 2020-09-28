using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 前回までの授業
            //var list = new List<string>
            //{
            //    "Tokyou","New Delhi","Bankok","London","Parlis","Berlin","Canbera","Hong Kong",
            //};
            #region 先頭の文字Aが存在するのか
            //var exists = list.Exists(s => s[0] == 'A');
            //Console.WriteLine(exists);
            #endregion
            #region 文字列が6文字ならその名前を表示
            //
            //var name = list.Find(s => s.Length == 6);
            //Console.WriteLine(name);
            #endregion
            #region 5文字以下の名前を出力
            //
            //var name = list.FindAll(s => s.Length <= 5);
            //foreach (var item in name)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region foreachを使わずに1文で済ませる
            //list.ForEach(s => Console.WriteLine(s));
            //list.FindAll(s => s.Length <= 5).ForEach(s=>Console.WriteLine(s));
            #endregion
            #region すべて大文字で出力
            //var names = list.ConvertAll(s=>s.ToUpper());
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            //1文で済ませる
            //list.ConvertAll(s => s.ToUpper()).ForEach(s=>Console.WriteLine(s));
            #endregion

            #endregion

            var names = new List<string>
            {
                "Tokyo","New Delhi","Bankok","London","Paris","Berlin","Canbera","Hong Kong",
            };

            //即時実行→ToList()
            var query = names.Where(s => s.Length <= 5).ToList();
            //var query = names.Where(s => s.Length <= 5);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");

            //遅延実行
            names[0] = "Osaka";
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
