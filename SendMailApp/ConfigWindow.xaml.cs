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
            Config cf = (Config.GetInstance()).getDefaultStatus();

            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbSender.Text = tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;
        }
        //適用（更新）
        private void btApply_Click(object sender, RoutedEventArgs e)
        {
            (Config.GetInstance()).UpdateStatus(
                tbSmtp.Text,
                tbUserName.Text,
                tbPassWord.Password,
                int.Parse(tbPort.Text),
                cbSsl.IsChecked ?? false);   //更新処理を呼び出す
        }
        //OKボタン
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            if (tbSmtp.Text == "")
            {
                MessageBox.Show("SMTPが入力されていません");
            }
            else if (int.Parse(tbPort.Text) == 0)
            {
                MessageBox.Show("ポートが入力されていません");
            }
            else if (tbUserName.Text == "")
            {
                MessageBox.Show("ユーザー名が入力されていません");
            }
            else if (tbPassWord.Password == "")
            {
                MessageBox.Show("パスワードが入力されていません");
            }
            else
            {
                btApply_Click(sender, e);   //更新処理を呼び出す
                this.Close();
            }
        }
        //キャンセルボタン
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //ロード時に一度だけ呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // btDefault_Click(sender, e);
                Config.GetInstance().DeSerialise();//逆シリアル化　XML⇒オブジェクト
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
          
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            try
            {
                Config.GetInstance().Serialise(); //シリアル化　オブジェクト⇒XML
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
