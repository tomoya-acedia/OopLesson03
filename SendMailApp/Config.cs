using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

namespace SendMailApp 
{
    public class Config 
    {
        //単一のインスタンス
        //private static Config instance = null;
        private static Config instance { get; set; }

        public string Smtp { get; set; }//SMTPサーバー
        public string MailAddress { get; set; } //自メールアドレス(送信元)
        public string PassWord { get; set; } //パスワード
        public int Port { get; set; }//ポート番号
        public bool Ssl { get; set; } //SSL設定

        //コンストラクタ(外部からnewできないようにする)
        private Config()
        {
        }

        //インスタンスの取得
        public static Config GetInstance() 
        {
            if (instance == null)
            {
                instance = new Config();

            }
            return instance;
        }

        //初期設定値
        public void DefaultSet() 
        {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            Port = 587;
            Ssl = true;
        }

        //初期値取得
        public Config getDefaultStatus()
        {
            Config obj = new Config 
            {
                Smtp = "smtp.gmail.com",
                MailAddress = "ojsinfosys01@gmail.com",
                PassWord = "ojsInfosys2020",
                Port = 587,
                Ssl = true
            };
            return obj;
        }

        //設定データ更新
        //public bool UpdateStatus(Config cf) //←仮引数(cf)
        public bool UpdateStatus(string smtp, string mailAddress, string passWord, int port, bool ssl) 
        {
            this.Smtp = smtp;
            this.MailAddress = mailAddress;
            this.PassWord = passWord;
            this.Port = port;
            this.Ssl = ssl;

            return true;
        }

        public void Serialise()     //シリアル化 P305参照 
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Config));
                StreamWriter sw = new StreamWriter("Config.xml");
                Config cf = Config.GetInstance();
                xs.Serialize(sw, cf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void DeSerialise()       //逆シリアル化 P307参照 
        {
            try
            {
                using (StreamReader sr = new StreamReader("Config.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Config));
                    instance = xs.Deserialize(sr) as Config;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}