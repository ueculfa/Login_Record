using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ad = textBox1.Text;
            string Soyad = textBox2.Text;   
            string KullaniciAdi = textBox3.Text;
            string Sifre = textBox4.Text;

            if(Ad =="" || Soyad== ""|| KullaniciAdi =="" ||Sifre =="")
            {
                MessageBox.Show("Eksik Giriş Yapıldı");
            }
            else
            {
                MessageBox.Show("Kaydeldi");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked) 
            {
                textBox4.UseSystemPasswordChar = true;
                checkBox1.Text = "Şifreyi Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox4.UseSystemPasswordChar = false;
                checkBox1.Text = "Şifreyi Göster";
            }
        }
    }
}
