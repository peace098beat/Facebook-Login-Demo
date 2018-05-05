namespace WebformButtonClickDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button_ClearCache = new System.Windows.Forms.Button();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Insert_LoginPass = new System.Windows.Forms.Button();
            this.button_WebHome = new System.Windows.Forms.Button();
            this.button_Scroll_Down = new System.Windows.Forms.Button();
            this.button_MarkLikeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(757, 686);
            this.webBrowser1.TabIndex = 0;
            // 
            // button_ClearCache
            // 
            this.button_ClearCache.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ClearCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearCache.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_ClearCache.Location = new System.Drawing.Point(12, 98);
            this.button_ClearCache.Name = "button_ClearCache";
            this.button_ClearCache.Size = new System.Drawing.Size(186, 23);
            this.button_ClearCache.TabIndex = 6;
            this.button_ClearCache.Text = "Clear cache";
            this.button_ClearCache.UseVisualStyleBackColor = false;
            this.button_ClearCache.Click += new System.EventHandler(this.button_ClearCache_Click);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Pass.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Pass.Location = new System.Drawing.Point(44, 39);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(154, 21);
            this.textBox_Pass.TabIndex = 4;
            // 
            // textBox_ID
            // 
            this.textBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ID.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_ID.Location = new System.Drawing.Point(44, 14);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(154, 21);
            this.textBox_ID.TabIndex = 3;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Login.Location = new System.Drawing.Point(22, 178);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(166, 23);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "LOGINボタンをクリック";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.ForeColor = System.Drawing.Color.YellowGreen;
            this.textBox1.Location = new System.Drawing.Point(15, 456);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(189, 219);
            this.textBox1.TabIndex = 1;
            // 
            // button_Insert_LoginPass
            // 
            this.button_Insert_LoginPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Insert_LoginPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Insert_LoginPass.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Insert_LoginPass.Location = new System.Drawing.Point(22, 152);
            this.button_Insert_LoginPass.Name = "button_Insert_LoginPass";
            this.button_Insert_LoginPass.Size = new System.Drawing.Size(166, 22);
            this.button_Insert_LoginPass.TabIndex = 0;
            this.button_Insert_LoginPass.Text = "IDとPassをフォーム入力";
            this.button_Insert_LoginPass.UseVisualStyleBackColor = false;
            this.button_Insert_LoginPass.Click += new System.EventHandler(this.button_Insert_LoginPass_Click);
            // 
            // button_WebHome
            // 
            this.button_WebHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_WebHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WebHome.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_WebHome.Location = new System.Drawing.Point(12, 125);
            this.button_WebHome.Name = "button_WebHome";
            this.button_WebHome.Size = new System.Drawing.Size(186, 23);
            this.button_WebHome.TabIndex = 5;
            this.button_WebHome.Text = "Facebookのログインページを表示";
            this.button_WebHome.UseVisualStyleBackColor = false;
            this.button_WebHome.Click += new System.EventHandler(this.button_WebHome_Click);
            // 
            // button_Scroll_Down
            // 
            this.button_Scroll_Down.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Scroll_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Scroll_Down.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Scroll_Down.Location = new System.Drawing.Point(12, 205);
            this.button_Scroll_Down.Name = "button_Scroll_Down";
            this.button_Scroll_Down.Size = new System.Drawing.Size(186, 23);
            this.button_Scroll_Down.TabIndex = 7;
            this.button_Scroll_Down.Text = "↓にスクロール";
            this.button_Scroll_Down.UseVisualStyleBackColor = false;
            this.button_Scroll_Down.Click += new System.EventHandler(this.button_Scroll_Down_Click);
            // 
            // button_MarkLikeButton
            // 
            this.button_MarkLikeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_MarkLikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MarkLikeButton.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_MarkLikeButton.Location = new System.Drawing.Point(11, 244);
            this.button_MarkLikeButton.Name = "button_MarkLikeButton";
            this.button_MarkLikeButton.Size = new System.Drawing.Size(186, 23);
            this.button_MarkLikeButton.TabIndex = 8;
            this.button_MarkLikeButton.Text = "いいねをマーク";
            this.button_MarkLikeButton.UseVisualStyleBackColor = false;
            this.button_MarkLikeButton.Click += new System.EventHandler(this.button_MarkLikeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "PW";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Blue;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button_Refresh);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_ID);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button_ClearCache);
            this.splitContainer1.Panel1.Controls.Add(this.button_MarkLikeButton);
            this.splitContainer1.Panel1.Controls.Add(this.button_WebHome);
            this.splitContainer1.Panel1.Controls.Add(this.button_Scroll_Down);
            this.splitContainer1.Panel1.Controls.Add(this.button_Insert_LoginPass);
            this.splitContainer1.Panel1.Controls.Add(this.button_Login);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Pass);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(984, 688);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 11;
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Refresh.Location = new System.Drawing.Point(157, 66);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(41, 23);
            this.button_Refresh.TabIndex = 11;
            this.button_Refresh.Text = "更新";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(11, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "いいねをマーク";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 688);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Insert_LoginPass;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button button_WebHome;
        private System.Windows.Forms.Button button_ClearCache;
        private System.Windows.Forms.Button button_Scroll_Down;
        private System.Windows.Forms.Button button_MarkLikeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button1;
    }
}

