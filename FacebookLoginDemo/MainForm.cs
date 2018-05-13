using System;
using System.Windows.Forms;

namespace FacebookLoginDemo
{
    /// <summary>
    /// フェイスブックに自動ログインするだけのアプリ
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// おまじない
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// UIがロードされたときに呼び出される処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            /* まずはURL先を表示する */
            string facebook_URL = "https://www.facebook.com/";
            webBrowser1.Navigate(facebook_URL);

            /*  [デバッグ] 説明文 */
            #region デバッグ用の説明文
            string Setumei = "";
                    Setumei += "** 使い方 ***\n";
                    Setumei += "** 1 ***\n";
                    Setumei += "** IDとPASSボタンをおして自動入力してください\n";
                    Setumei += "** 2 ***\n";
                    Setumei += "** ログインボタンをおして、ログインボタンのクリックイベントを発行させてください\n";
                    Setumei += "** 終わり ***\n";
                    Setumei += facebook_URL + "にアクセスしました\n";

            textBox1.Text = Setumei;　 // デバッグ用にテキストボックスに説明文を表示
            #endregion

        }


        /// <summary>
        /// 更新ボタンをクリックされたら呼ばれるイベント
        /// </summary>
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }


        /// <summary>
        /// ログインボタンをクリックされたら呼ばれるイベント
        /// </summary>
        private void button_Login_Click(object sender, EventArgs e)
        {
            /* ログインボタンの処理 */

            /* id=loginbuttonのボタン要素を取得 */
            HtmlElement btn = webBrowser1.Document.GetElementById("loginbutton");

            /* ボタンをクリック! */
            btn.InvokeMember("click");

            /* [デバッグ] テキストボックスに説明文を表示 */
            textBox1.AppendText("ログインボタンをクリックしました" + Environment.NewLine);　 // デバッグ用にテキストボックスに説明文を表示
            textBox1.AppendText("認証を問い合わせているので少々お待ちください。10秒ぐらい" + Environment.NewLine);　 // デバッグ用にテキストボックスに説明文を表示
        }



        /// <summary>
        /// ログインボタンをクリックされたら呼ばれるイベント
        /// アカウント・パスワードをBoxに入力
        /// </summary>
        private void button_Insert_LoginPass_Click(object sender, EventArgs e)
        {
            /* input要素を全部取得 */
            HtmlElementCollection InputCollection = webBrowser1.Document.GetElementsByTagName("input");

            string FB_ID_Text = this.textBox_ID.Text; // UI(テキストボックス)から入力テキストを取得
            string FB_Pass_Text = this.textBox_Pass.Text; // UI(テキストボックス)から入力テキストを取得

            /* input要素のコレクションから, email入力Boxとパスワード入力Boxの要素を取得. jQuery的な */
            foreach (HtmlElement input_element in InputCollection)
            {
                /* アカウント入力用box */
                if (input_element.GetAttribute("name") == "email")
                {
                    input_element.SetAttribute("value", FB_ID_Text);
                    textBox1.AppendText("IDを入力しました" + Environment.NewLine); // デバッグ用にテキストボックスに説明文を表示
                }

                /* パスワード入力ボックス */
                if (input_element.GetAttribute("name") == "pass")
                {
                    input_element.SetAttribute("value", FB_Pass_Text);
                    textBox1.AppendText("PASSを入力しました" + Environment.NewLine); // デバッグ用にテキストボックスに説明文を表示
                }
            }

        }

    }


}
