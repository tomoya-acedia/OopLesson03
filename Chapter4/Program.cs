using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        #region リスト4.27(～P.116まで)
        //static void Main(string[] args)
        //{
        //    string code = "12345";

        //    var message = GetMessage(code) ?? DefaultMessage();
        //    Console.WriteLine(message);
        //}

        ////スタブ
        //private static object DefaultMessage()
        //{
        //    return "DefaultMessage";
        //}

        ////スタブ
        //private static object GetMessage(string code)
        //{
        //    return "1";
        //}
        #endregion

        #region リスト4.28(～P.117まで)
        static void Main(string[] args)
        {
            Console.WriteLine(GetProduct());
        }
        
        private static string GetProduct()
        {
            Sale sale = new Sale
            {
                ShopNema = "pet store",
                //Amount = 1000000,
                Product = "food",
            };

            sale = null;

            //Productの値を返す
            //?があるとnullの時でも実行可能、?がないと例外エラー
            return sale?.Product;
        }

        class Sale
        {
            //店舗名
            public string ShopNema { get; set; }

            //売上高
            public int Amount { get; set; } = 1000000;  //初期化(オブジェクトの初期化はしない)
            public string Product { get; set; }
        }
        #endregion
    }
}
