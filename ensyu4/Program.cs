using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ensyu4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4-2-1
            var ymCollection = new YearMonth[]
            {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2020,7),
                new YearMonth(2010,9),
                new YearMonth(2020,12),
            };


            //4-2-2
            Console.WriteLine("--4.2.2--");
            foreach (var item in ymCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            //4-2-3
            Console.WriteLine("--4.2.3--");
            Console.WriteLine(FindFirst21C(ymCollection));
            Console.WriteLine("----------");

            //4-2-4
            Console.WriteLine("--4.2.4--");
            Exerceise2_4(ymCollection);
            Console.WriteLine("----------");

            //4-2-5
            Console.WriteLine("--4.2.5--");
            Exerceise2_5(ymCollection);
            Console.WriteLine("----------");
        }

        //4-2-3
        static YearMonth FindFirst21C(YearMonth[] yms)
        {
            foreach (var item in yms)
            {
                //21世紀ならretrunして終了
                if (item.Is21Century)
                {
                    return item;
                }
            }
            //21世紀が存在しなければnullを返却
            return null;
        }

        //4-2-4
        private static void Exerceise2_4(YearMonth[] ymCollection)
        {
            var yearmonth = FindFirst21C(ymCollection);

#if false
            var s = yearmonth == null ? "21世紀のデータはありません" : yearmonth.ToString();

#else
            if (yearmonth == null)
                Console.WriteLine("21世紀のデータはありません");

            else
                Console.WriteLine(yearmonth);
#endif
        }

        //4-2-5
        private static void Exerceise2_5(YearMonth[] ymCollection)
        {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array)
            {
                Console.WriteLine(ym);
            }
        }
    }
}
