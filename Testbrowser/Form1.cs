using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;


namespace Testbrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceStock1.ServiceClient test = new ServiceStock1.ServiceClient();
            try
            {
                quote_ans.Text=test.getStockquote(enc_text.Text);
            }
            catch(Exception ec)
            {
                quote_ans.Text = ec.Message.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void en_button_Click(object sender, EventArgs e)
        {
            ServiceEncrypt.ServiceClient test = new ServiceEncrypt.ServiceClient();
            try
            {
                en_ans.Text = test.Encrypt(en_input.Text);
            }
            catch(Exception ec)
            {
                en_ans.Text = ec.Message.ToString();
            }
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            ServiceEncrypt.ServiceClient test = new ServiceEncrypt.ServiceClient();
            try
            {
                dec_ans.Text= test.Decrypt(en_ans.Text);
            }
            catch (Exception ec)
            {
                dec_ans.Text = ec.Message.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
