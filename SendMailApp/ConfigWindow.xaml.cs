using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SendMailApp
{
    /// <summary>
    /// ConfigWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindow : Window
    {
        public ConfigWindow()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, RoutedEventArgs e)
        {
            Config cf = (Config.GetInstance()).getDefaultStatic();

            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbSender.Text = tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;
        }

        //適用(更新)
        private void btApply_Click(object sender, RoutedEventArgs e)
        {
            if (tbSmtp.Text == "" || tbUserName.Text == "" || tbPassWord.Password == "" || tbPort.Text == "")
            {
                MessageBox.Show("警告");
            }
            else
            {
                //更新処理を呼び出す
                (Config.GetInstance()).UpdateStatus(tbSmtp.Text, tbUserName.Text, tbPassWord.Password, int.Parse(tbPort.Text), cbSsl.IsChecked ?? false);
            }
        }

        //OKボタン
        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            if (tbPassWord.Password == "")
            {
                MessageBox.Show("パスワードを入力してください");
            }
            else if (int.Parse(tbPort.Text) == 0)
            {
                MessageBox.Show("ポート番号を入力してください");
            }
            else if (tbSmtp.Text == "")
            {
                MessageBox.Show("SMTPを入力してください");
            }
            else if (tbUserName.Text == "")
            {
                MessageBox.Show("メールアドレスを入力してください");
            }
            else
            {
                btApply_Click(sender, e);   //更新処理を呼び出す
                this.Close();
            }
        }

        //Cancelボタン
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            if (tbPassWord.Password != null || tbPort.Text != null
                || tbSmtp.Text != null || tbUserName.Text != null)
            {
                MessageBoxResult result = MessageBox.Show("変更が反映されていません。", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    this.Close();

                }
                else if (result == MessageBoxResult.Cancel)
                {
                }
            }
        }

        //設定画面ロード時に一度だけ呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Config stf = (Config.GetInstance());
            tbUserName.Text = stf.MailAddress;
            tbPassWord.Password = stf.PassWord;
            tbSmtp.Text = stf.Smtp;
            cbSsl.IsChecked = stf.Ssl;
            tbSender.Text = stf.MailAddress;
            tbPort.Text = stf.Port.ToString();
        }
    }
}
