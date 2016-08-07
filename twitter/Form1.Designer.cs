namespace twitter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTweetListeleUser = new System.Windows.Forms.Button();
            this.btnTweetSil = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTweetGonder = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnTweetListeleHome = new System.Windows.Forms.Button();
            this.btnFavoriler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTweetListeleUser
            // 
            this.btnTweetListeleUser.Location = new System.Drawing.Point(538, 95);
            this.btnTweetListeleUser.Name = "btnTweetListeleUser";
            this.btnTweetListeleUser.Size = new System.Drawing.Size(239, 23);
            this.btnTweetListeleUser.TabIndex = 9;
            this.btnTweetListeleUser.Text = "Tweet Listele User";
            this.btnTweetListeleUser.UseVisualStyleBackColor = true;
            this.btnTweetListeleUser.Click += new System.EventHandler(this.btnTweetListeleUser_Click);
            // 
            // btnTweetSil
            // 
            this.btnTweetSil.Location = new System.Drawing.Point(538, 66);
            this.btnTweetSil.Name = "btnTweetSil";
            this.btnTweetSil.Size = new System.Drawing.Size(239, 23);
            this.btnTweetSil.TabIndex = 8;
            this.btnTweetSil.Text = "Tweet Sil";
            this.btnTweetSil.UseVisualStyleBackColor = true;
            this.btnTweetSil.Click += new System.EventHandler(this.btnTweetSil_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(520, 459);
            this.listBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(538, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnTweetGonder
            // 
            this.btnTweetGonder.Location = new System.Drawing.Point(538, 37);
            this.btnTweetGonder.Name = "btnTweetGonder";
            this.btnTweetGonder.Size = new System.Drawing.Size(239, 23);
            this.btnTweetGonder.TabIndex = 5;
            this.btnTweetGonder.Text = "Tweet Gönder";
            this.btnTweetGonder.UseVisualStyleBackColor = true;
            this.btnTweetGonder.Click += new System.EventHandler(this.btnTweetGonder_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(783, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(320, 459);
            this.listBox2.TabIndex = 10;
            // 
            // btnTweetListeleHome
            // 
            this.btnTweetListeleHome.Location = new System.Drawing.Point(538, 124);
            this.btnTweetListeleHome.Name = "btnTweetListeleHome";
            this.btnTweetListeleHome.Size = new System.Drawing.Size(239, 23);
            this.btnTweetListeleHome.TabIndex = 11;
            this.btnTweetListeleHome.Text = "Tweet Listele Home";
            this.btnTweetListeleHome.UseVisualStyleBackColor = true;
            this.btnTweetListeleHome.Click += new System.EventHandler(this.btnTweetListeleHome_Click);
            // 
            // btnFavoriler
            // 
            this.btnFavoriler.Location = new System.Drawing.Point(538, 153);
            this.btnFavoriler.Name = "btnFavoriler";
            this.btnFavoriler.Size = new System.Drawing.Size(239, 23);
            this.btnFavoriler.TabIndex = 12;
            this.btnFavoriler.Text = "Favoriler";
            this.btnFavoriler.UseVisualStyleBackColor = true;
            this.btnFavoriler.Click += new System.EventHandler(this.btnFavoriler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 487);
            this.Controls.Add(this.btnFavoriler);
            this.Controls.Add(this.btnTweetListeleHome);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnTweetListeleUser);
            this.Controls.Add(this.btnTweetSil);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTweetGonder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTweetListeleUser;
        private System.Windows.Forms.Button btnTweetSil;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTweetGonder;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnTweetListeleHome;
        private System.Windows.Forms.Button btnFavoriler;
    }
}

