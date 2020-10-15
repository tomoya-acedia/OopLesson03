using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 教科書P.188まで
            //var flowerDict = new Dictionary<string, int>()
            //{
            //    ["sunflower"] = 400,
            //    ["pansy"] = 300,
            //    ["tulip"] = 350,
            //    ["rose"] = 500,
            //    ["dahlia"] = 450,
            //};

            //flowerDict["violet"] = 600;
            //flowerDict.Add("violet", 700);  //Addメソッドで同じ名前のものを追加すると例外エラー
            //flowerDict["violet"] = 800;     //この場合は上書きされる

            //foreach (var item in flowerDict)
            //{
            //    Console.WriteLine($"{item.Key} = {item.Value}");
            //}
            #endregion

            #region P.190まで
            //var employeeDict = new Dictionary<int, Employee>()
            //{
            //    {100,new Employee(100,"清水遼久") },
            //    {112,new Employee(112,"芦沢洋和") },
            //    {125,new Employee(125,"岩瀬奈央子") },
            //};

            //foreach (KeyValuePair<int, Employee> item in employeeDict)
            //{
            //    Console.WriteLine($"{item.Value.Id} = {item.Value.Name}");
            //}

            //var num = employeeDict.Sum(n => n.Value.Id);
            //var num = employeeDict.Average(n => n.Value.Id);

            //var employees = employeeDict.Where(n => n.Value.Id % 2 == 0);

            //foreach (var item in employees)
            //{
            //    Console.WriteLine($"{ item.Value.Name}");
            //}

            #endregion

            #region　P.191まで
            //リスト
            //var employee = new List<Employee>()
            //{
            //    new Employee(100,"清水遼久"),
            //    new Employee(112,"芦沢洋和"),
            //    new Employee(125,"岩瀬奈央子"),
            //    new Employee(143,"山田太郎"),
            //    new Employee(148,"池田次郎"),
            //    new Employee(152,"高田三郎"),
            //    new Employee(155,"石川幸也"),
            //    new Employee(161,"中沢信也"),
            //};

            ////IDが偶数のみディクショナリーに変換する
            ////var employeeDict = employee.ToDictionary(emp => emp.Id);
            //var employeeDict= employee.Where(n => n.Id % 2 == 0).ToDictionary(emp => emp.Id);

            //foreach (KeyValuePair<int, Employee> item in employeeDict)
            //{
            //    Console.WriteLine($"{item.Value.Id}  {item.Value.Name}");
            //}
            #endregion
            #region ここまで
            //var dict = new Dictionary<MonthDay, string>
            //{
            //    {new MonthDay(3,5),"珊瑚の日"},
            //    {new MonthDay(8,4),"箸の日"},
            //    {new MonthDay(10,3),"登山の日"},
            //};
            //var md = new MonthDay(8, 4);
            //var s = dict[md];
            //Console.WriteLine(s);

            //テキストファイルを読み込む
            var lines = File.ReadAllLines("sample.txt");
            var we = new WordsExtractor(lines);
            foreach (var word in we.Extract())
            {
                Console.WriteLine(word);
            }
            #endregion

            DuplicateKeySample();
        }

        static public void DuplicateKeySample()
        {
            // ディクショナリの初期化
            var dict = new Dictionary<string, List<string>>() {
               { "PC", new List<string> { "パーソナル コンピュータ", "プログラム カウンタ", } },
               { "CD", new List<string> { "コンパクト ディスク", "キャッシュ ディスペンサー", } },
            };

            // ディクショナリに追加
            var key = "EC";
            var value = "電子商取引";
            if (dict.ContainsKey(key))
            {
                dict[key].Add(value);
            }
            else
            {
                dict[key] = new List<string> { value };
            }

            // ディクショナリの内容を列挙
            foreach (var item in dict)
            {
                foreach (var term in item.Value)
                {
                    Console.WriteLine("{0} : {1}", item.Key, term);
                }
            }
        }
    }
}