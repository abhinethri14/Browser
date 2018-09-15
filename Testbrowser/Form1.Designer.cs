namespace Testbrowser
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
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_Go = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit_stk_btn = new System.Windows.Forms.Button();
            this.quote_ans = new System.Windows.Forms.TextBox();
            this.enc_text = new System.Windows.Forms.TextBox();
            this.stck_label = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dec_ans = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.en_ans = new System.Windows.Forms.TextBox();
            this.en_button = new System.Windows.Forms.Button();
            this.en_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 30);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1385, 927);
            this.webBrowser1.TabIndex = 0;
            // 
            // btn_Go
            // 
            this.btn_Go.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Go.Location = new System.Drawing.Point(581, 0);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(59, 26);
            this.btn_Go.TabIndex = 4;
            this.btn_Go.Text = "GO";
            this.btn_Go.UseVisualStyleBackColor = false;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 2);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(563, 22);
            this.txtURL.TabIndex = 3;
            this.txtURL.Text = "http://";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.submit_stk_btn);
            this.groupBox1.Controls.Add(this.quote_ans);
            this.groupBox1.Controls.Add(this.enc_text);
            this.groupBox1.Controls.Add(this.stck_label);
            this.groupBox1.Location = new System.Drawing.Point(882, 536);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 283);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service3";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "StockQuote";
            // 
            // submit_stk_btn
            // 
            this.submit_stk_btn.Location = new System.Drawing.Point(275, 78);
            this.submit_stk_btn.Name = "submit_stk_btn";
            this.submit_stk_btn.Size = new System.Drawing.Size(75, 23);
            this.submit_stk_btn.TabIndex = 5;
            this.submit_stk_btn.Text = "Submit";
            this.submit_stk_btn.UseVisualStyleBackColor = true;
            this.submit_stk_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // quote_ans
            // 
            this.quote_ans.Location = new System.Drawing.Point(178, 127);
            this.quote_ans.Name = "quote_ans";
            this.quote_ans.Size = new System.Drawing.Size(172, 22);
            this.quote_ans.TabIndex = 4;
            // 
            // enc_text
            // 
            this.enc_text.Location = new System.Drawing.Point(187, 50);
            this.enc_text.Name = "enc_text";
            this.enc_text.Size = new System.Drawing.Size(163, 22);
            this.enc_text.TabIndex = 3;
            this.enc_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stck_label
            // 
            this.stck_label.AutoSize = true;
            this.stck_label.Location = new System.Drawing.Point(26, 53);
            this.stck_label.Name = "stck_label";
            this.stck_label.Size = new System.Drawing.Size(155, 17);
            this.stck_label.TabIndex = 1;
            this.stck_label.Text = "Enter the Stock Symbol";
            this.stck_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dec_ans);
            this.groupBox2.Controls.Add(this.send_btn);
            this.groupBox2.Controls.Add(this.en_ans);
            this.groupBox2.Controls.Add(this.en_button);
            this.groupBox2.Controls.Add(this.en_input);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(28, 538);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 281);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Decrypted message:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Encrypted message:";
            // 
            // dec_ans
            // 
            this.dec_ans.Location = new System.Drawing.Point(22, 232);
            this.dec_ans.Name = "dec_ans";
            this.dec_ans.Size = new System.Drawing.Size(419, 22);
            this.dec_ans.TabIndex = 5;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(22, 173);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(419, 25);
            this.send_btn.TabIndex = 4;
            this.send_btn.Text = "Click here to check whether Decryption is correct";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // en_ans
            // 
            this.en_ans.Location = new System.Drawing.Point(22, 145);
            this.en_ans.Name = "en_ans";
            this.en_ans.Size = new System.Drawing.Size(419, 22);
            this.en_ans.TabIndex = 3;
            // 
            // en_button
            // 
            this.en_button.Location = new System.Drawing.Point(22, 84);
            this.en_button.Name = "en_button";
            this.en_button.Size = new System.Drawing.Size(75, 23);
            this.en_button.TabIndex = 2;
            this.en_button.Text = "Submit";
            this.en_button.UseVisualStyleBackColor = true;
            this.en_button.Click += new System.EventHandler(this.en_button_Click);
            // 
            // en_input
            // 
            this.en_input.Location = new System.Drawing.Point(22, 56);
            this.en_input.Name = "en_input";
            this.en_input.Size = new System.Drawing.Size(419, 22);
            this.en_input.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter the message which needs to be encrypted: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1382, 953);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abhinethri\'s browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label stck_label;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox enc_text;
        private System.Windows.Forms.Button submit_stk_btn;
        private System.Windows.Forms.TextBox quote_ans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button en_button;
        private System.Windows.Forms.TextBox en_input;
        private System.Windows.Forms.TextBox en_ans;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox dec_ans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}

