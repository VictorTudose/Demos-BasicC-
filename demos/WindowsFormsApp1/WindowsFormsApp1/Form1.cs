using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        bool[] text=new bool[4];
        bool agreed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.PasswordChar = '*';
            textBox3.MaxLength = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (bool b in text)
                if (!b)
                    return;
            if (!agreed)
                return;

            ((Button)sender).Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text[0] = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            text[1] = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            text[2] = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            text[3] = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (agreed)
            {
                agreed = false;
                return;
            }
            agreed = true;
        }
    }
}
