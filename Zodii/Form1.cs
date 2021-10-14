using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zodii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        public static int nr = 0,a;
        private void button1_Click(object sender, EventArgs e)
        {
            int z, l;
            nr = 0;
            z = Int32.Parse(textBox1.Text);
            l = Int32.Parse(textBox2.Text);
            a = Int32.Parse(textBox3.Text);
            if (a >= 21 && a <= 99)
                a = 1900 + a;
            if (a <= 20 && a >= 0)
                a = 2000 + a;
            if (l == 3)
            { 
                if (z >= 1 && z <= 20)
                    nr = 12;
                if (z >= 21 && z <= 31)
                    nr = 1;
            }
            if (l == 4)
            {
                if (z <= 20 && z >= 1)
                    nr = 1;
                if (z >= 21 && z <= 30)
                    nr = 2;
            }
            if (l == 5)
            {
                if (z <= 21 && z >= 1)
                    nr = 2;
                if (z >= 22 && z <= 31)
                    nr = 3;
            }
            if (l == 6)
            {
                if (z <= 21 && z >= 1)
                    nr = 3;
                if (z >= 22 && z <= 30)
                    nr = 4;
            }
            if (l == 7)
            {
                if (z <= 22 && z >= 1)
                    nr = 4;
                if (z >= 23 && z <= 31)
                    nr = 5;
            }
            if (l == 8)
            {
                if (z <= 22 & z >= 1)
                    nr = 5;
                if (z >= 23 && z <= 31)
                    nr = 6;
            }
            if (l == 9)
            {
                if (z <= 23 && z >= 1)
                    nr = 6;
                if (z >= 24 && z <= 30)
                    nr = 7;
            }
            if (l == 10)
            {
                if (z <= 23 && z >= 1)
                    nr = 7;
                if (z >= 24 && z <= 31)
                    nr = 8;
            }
            if (l == 11)
            {
                if (z <= 22 && z >= 1)
                    nr = 8;
                if (z >= 23 && z <= 30)
                    nr = 9;
            }
            if (l == 12)
            {
                if (z <= 21 && z >= 1)
                    nr = 9;
                if (z >= 22 && z <= 31)
                    nr = 10;
            }
            if (l == 1)
            {
                if (z <= 20 && z >= 1)
                    nr = 10;
                if (z >= 21 && z <= 31)
                    nr = 11;
            }
            if (l == 2)
            {
                if (z <= 19 && z >= 1)
                    nr = 11;
                if (z >= 20 && z <= 29)
                    nr = 12;
            }
            if (nr == 0 || l<1 || l>12)
                MessageBox.Show("Datele introduse nu sunt corecte.");
            else{
                if (a < 1800)
                    MessageBox.Show("Anul nasterii nu este corect.");
                else
                {
                    string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
                    string f = filePath + "\\" + "text" + nr + ".txt";
                    richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
                    string f2 = filePath + "\\" + "nr" + nr + ".jpg";
                    pictureBox1.Load(f2);
                    button2.Show();
                    button3.Show();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Hide();
            button3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            richTextBox1.Clear();
            button2.Hide();
            button3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 secondForm = new Form3();
            secondForm.Show();
        }
    }
}
