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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int a;
        private void Form2_Load(object sender, EventArgs e)
        {
            a = (Form1.nr);
            if (a == 1)
                textBox1.Text="Compatibilitate berbec cu:";
            if (a == 2)
                textBox1.Text = "Compatibilitate taur cu:";
            if (a == 3)
                textBox1.Text = "Compatibilitate gemeni cu:";
            if (a == 4)
                textBox1.Text = "Compatibilitate rac cu:";
            if (a == 5)
                textBox1.Text = "Compatibilitate leu cu:";
            if (a == 6)
                textBox1.Text="Compatibilitate fecioara cu:";
            if (a == 7)
                textBox1.Text = "Compatibilitate balanta cu:";
            if (a == 8)
                textBox1.Text = "Compatibilitate scorpion cu:";
            if (a == 9)
                textBox1.Text = "Compatibilitate sagetator cu:";
            if (a == 10)
                textBox1.Text = "Compatibilitate capricorn cu:";
            if (a == 11)
                textBox1.Text = "Compatibilitate varsator cu:";
            if (a == 12)
                textBox1.Text = "Compatibilitate pesti cu:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp"+ a +"_" + "1.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp" + a + "_" + "5.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp" + a + "_" + "9.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp" + a + "_" + "2.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp" + a + "_" + "6.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp" + a + "_" + "3.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp" + a + "_" + "4.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp" + a + "_" + "7.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp" + a + "_" + "8.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp" + a + "_" + "10.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp" + a + "_" + "11.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetFullPath(@"..\..\Resources");
            string f = filePath + "\\" + "comp" + a + "_" + "12.txt";
            richTextBox1.LoadFile(f, RichTextBoxStreamType.PlainText);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
