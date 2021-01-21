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
using MessageBox = System.Windows.MessageBox;

namespace SendMailApp 
{
    /// <summary>
    /// ConfigWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindow : Window 
    {

        public bool Change = false;

        public ConfigWindow() 
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, RoutedEventArgs e)
        {

            Config cf = Config.GetInstance().getDefaultStatus();

            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbSender.Text = tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;
        }

        //適用(更新)
        private void btApply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Config.GetInstance().UpdateStatus(
                tbSmtp.Text,
                tbUserName.Text,
                tbPassWord.Password,
                int.Parse(tbPort.Text),
                cbSsl.IsChecked ?? false);
                ChangeOk(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("値を入力してください");
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
                btApply_Click(sender, e); //更新処理を呼び出す
                this.Close();
            }
        }

        //Cancelボタン
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            //if (tbPassWord.Password != null || tbPort.Text != null
            //  || tbSmtp.Text != null || tbUserName.Text != null)
            if (Change == true)
            {
                MessageBoxResult result = MessageBox.Show("内容が変更されています。保存しますか？", "", MessageBoxButton.OKCancel);
               
                if (result == MessageBoxResult.OK)
                {
                    btApply_Click(sender, e);
                    this.Close();
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    ChangeOk(sender, e);
                    this.Close();
                }
            } 
            else {
                ChangeOk(sender, e);
                this.Close();
            }
        }

        //設定画面ロード時に一度だけ呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e) 
        {
            Config stf = Config.GetInstance();

            stf = Config.GetInstance();
            tbSmtp.Text = stf.Smtp;
            tbUserName.Text = stf.MailAddress;
            tbPassWord.Password = stf.PassWord;
            tbPort.Text = stf.Port.ToString();
            cbSsl.IsChecked = stf.Ssl;

        }

        private void Arate()
        {
            if (tbPassWord == null || tbPort == null || tbSender == null || tbSmtp == null || tbUserName == null) 
            {
                MessageBox.Show("正しい値を入力してください");
                return;
            }
        }

        private void ChangeOk(object sender, RoutedEventArgs e) 
        {
            Change = false;
        }
    }
}
