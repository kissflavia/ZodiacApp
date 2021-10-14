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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int x;
        private void Form3_Load(object sender, EventArgs e)
        {
            x = (Form1.a) % 1936 % 12 + 1;
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources\China");
            string f = filePath + "\\" + "ch" + x + ".txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
            string f2 = filePath + "\\" + "c" + x + ".jpg";
            pictureBox1.Load(f2);
            string f3 = filePath + "\\" + "nume" + x + ".txt";
            richTextBox2.LoadFile(f3, RichTextBoxStreamType.PlainText);


        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
