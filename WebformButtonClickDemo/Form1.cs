using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WebformButtonClickDemo
{
    public partial class Form1 : Form
    {
        string facebook_URL = "https://www.facebook.com/";
        string FB_ID_Text = "peace098beat.t@gmail.com";
        string FB_Pass_Text = "FFF2121098PBFFFf";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* 背景の設定 */
            this.splitContainer1.Panel1.BackColor = Color.FromArgb(60, 90, 155);

            /* URL先を表示する */
            webBrowser1.Navigate(facebook_URL);

            /* 説明文 */
            #region デバッグ用の説明文
            //string Setumei = "";
            //Setumei += "** 使い方 ***\n" ;
            //Setumei += "** 1 ***\n";
            //Setumei += "** IDとPASSボタンをおして自動入力してください\n";
            //Setumei += "** 2 ***\n";
            //Setumei += "** ログインボタンをおして、ログインボタンのクリックイベントを発行させてください\n";
            //Setumei += "** 終わり ***\n";
            //Setumei += facebook_URL + "にアクセスしました\n";

            /* デバッグ用にテキストボックスに説明文を表示 */
            //textBox1.Text = Setumei;
            #endregion

            /* デフォルト */
            textBox_ID.Text = FB_ID_Text;
            textBox_Pass.Text = FB_Pass_Text;

        }


        /// <summary>
        /// アカウント・パスワードをBoxに入力
        /// </summary>


        /// <summary>
        /// ログインボタンをクリック
        /// </summary>
        private void button_Login_Click(object sender, EventArgs e)
        {
            /* ログインボタンの処理 */

            /* id=loginbuttonのボタン要素を取得 */
            HtmlElement btn = webBrowser1.Document.GetElementById("loginbutton");


            /* ボタンをクリック! */
            btn.InvokeMember("click");

            /* デバッグ用にテキストボックスに説明文を表示 */
            //textBox1.AppendText("ログインボタンをクリックしました"+Environment.NewLine);
            //textBox1.AppendText("認証を問い合わせているので少々お待ちください。10秒ぐらい"+Environment.NewLine);
        }



        public void cache_clear()
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            prc.StartInfo.Arguments = @"RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8 /c";
            prc.Start();
            prc.WaitForExit();
            prc.Close();
        }


        private void button_ClearCache_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("about:blank");
            cache_clear();
            textBox1.AppendText("clear cache!" + Environment.NewLine);
        }

        private void button_WebHome_Click(object sender, EventArgs e)
        {

            /* URL先を表示する */
            webBrowser1.Navigate(facebook_URL);
            textBox1.AppendText("clear cache!" + Environment.NewLine);
        }

        private void button_Insert_LoginPass_Click(object sender, EventArgs e)
        {
            /* input要素を全部取得 */
            HtmlElementCollection InputCollection = webBrowser1.Document.GetElementsByTagName("input");

            /* input要素のコレクションから, email入力Boxとパスワード入力Boxの要素を取得. jQuery的な */
            foreach (HtmlElement input_element in InputCollection)
            {
                /* アカウント入力用box */
                if (input_element.GetAttribute("name") == "email")
                {
                    input_element.SetAttribute("value", this.FB_ID_Text);
                    textBox1.AppendText("IDを入力しました" + Environment.NewLine); // デバッグ用にテキストボックスに説明文を表示
                }

                /* パスワード入力ボックス */
                if (input_element.GetAttribute("name") == "pass")
                {
                    input_element.SetAttribute("value", this.FB_Pass_Text);
                    textBox1.AppendText("PASSを入力しました" + Environment.NewLine); // デバッグ用にテキストボックスに説明文を表示
                }
            }

        }

        private void button_Scroll_Down_Click(object sender, EventArgs e)
        {

            //[A Thinking Reed WebBrowserコントロール C#　スクロール量、マウスの移動等の取得](http://tanakakohei.blog39.fc2.com/blog-entry-36.html)

            // 現在のスクロール位置を取得
            HtmlElementCollection elements = webBrowser1.Document.GetElementsByTagName("html");
            int ScrollTop = elements[0].ScrollTop;
            int ScrollLeft = elements[0].ScrollLeft;

            int dY = 200; // 移動量

            //WebBrowserコントロールのスクロール位置
            webBrowser1.Document.Window.ScrollTo(new Point(ScrollLeft, ScrollTop + dY));

            elements = webBrowser1.Document.GetElementsByTagName("html");
            ScrollTop = elements[0].ScrollTop;
            ScrollLeft = elements[0].ScrollLeft;

        }


        void DebugWriteLine(string msg, bool NewLine = true)
        {

            if (NewLine)
            {
                textBox1.Text += msg + Environment.NewLine;
            }
            else
            {
                textBox1.Text += msg;
            }
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
            textBox1.Update();

        }

        private void button_MarkLikeButton_Click(object sender, EventArgs e)
        {

            List<HtmlElement> UFILikeLink_List = new List<HtmlElement>();

            /* search */
            HtmlElementCollection a_elms = webBrowser1.Document.GetElementsByTagName("a");
            foreach (HtmlElement a_elm in a_elms)
            {
                if (a_elm.GetAttribute("className").StartsWith("UFILikeLink"))
                {
                    UFILikeLink_List.Add(a_elm);
                }
            }

            int LikeCount = 0;
            foreach (HtmlElement elm in UFILikeLink_List)
            {
                elm.Style = "background-color: #FF0000";

                elm.InnerText = "ふぃいね" + (LikeCount.ToString());

                LikeCount++;
            }

            /* 最後のいいねに移動 */
            {
                HtmlElement elm = UFILikeLink_List[UFILikeLink_List.Count - 1];
                var point = GetOffset(elm);
                point.X = 0;
                webBrowser1.Document.Window.ScrollTo(point);
                DebugWriteLine(point.ToString());
            }

            DebugWriteLine($"{LikeCount}個のいいねボタンを見つけました");
            DebugWriteLine($"A elemens Count : {UFILikeLink_List.Count}");

        }

        /// <summary>
        /// HTML要素の絶対位置
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        public Point GetOffset(HtmlElement el)
        {
            //get element pos
            Point pos = new Point(el.OffsetRectangle.Left, el.OffsetRectangle.Top);

            //get the parents pos
            HtmlElement tempEl = el.OffsetParent;
            while (tempEl != null)
            {
                pos.X += tempEl.OffsetRectangle.Left;
                pos.Y += tempEl.OffsetRectangle.Top;
                tempEl = tempEl.OffsetParent;
            }

            return pos;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
