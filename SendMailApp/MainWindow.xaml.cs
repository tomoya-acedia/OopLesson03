using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SendMailApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        SmtpClient sc = new SmtpClient();

        public MainWindow()
        {
            InitializeComponent();
            sc.SendCompleted += Sc_SendCompleted;
        }

        //送信完了イベント
        private void Sc_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("送信はキャンセルされました。");
            }
            else
            {
                MessageBox.Show(e.Error?.Message ?? "送信完了!");
            }
        }

        //メール送信
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage("ojsinfosys01@gmail.com", tbTo.Text);

                if (tbCc.Text != "")
                {
                    msg.CC.Add(tbCc.Text); //
                }

                if (tbBcc.Text != "")
                {
                    msg.Bcc.Add(tbBcc.Text);
                }
                msg.Subject = tbTitle.Text; //件名
                msg.Body = tbBody.Text; //本文


                sc.Host = "smtp.gmail.com"; //SMTPサーバーの設定
                sc.Port = Config.GetInstance().Port;
                //sc.Port = 587; //PORTの設定
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential("ojsinfosys01@gmail.com", "ojsInfosys2020");
                //sc.Send(msg); //送信
                sc.SendMailAsync(msg);


                foreach (var item in tbFile.Items)
                {
                    msg.Attachments.Add(new Attachment(item.ToString()));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //送信キャンセル
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            sc.SendAsyncCancel();
        }

        //設定ボタンイベントハンドラ
        private void btConfig_Click(object sender, RoutedEventArgs e)
        {
            ConfigWindowShow();//設定画面表示
        }

        //画面表示
        private static void ConfigWindowShow()
        {
            ConfigWindow configWindow = new ConfigWindow();     //設定画面のインスタンス生成
            configWindow.ShowDialog();      //表示
        }

        //メインウィンドウがロードされるタイミングで呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Config.GetInstance().DeSerialise();//逆シリアル化 XML → オブジェクト
            }
            catch (FileNotFoundException)
            {
                ConfigWindowShow();//ファイルが存在しないので設定画面を先に表示
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            try
            {
                Config.GetInstance().Serialise();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        //追加
        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            var fod = new OpenFileDialog();

            if (fod.ShowDialog() == true)
            {

                tbFile.Items.Add(fod.FileName);

            }
        }

        //削除
        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            tbFile.Items.Clear();
        }
    }
}
