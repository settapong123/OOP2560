using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_type.Text = "bool";
            txt_size.Text = sizeof(bool).ToString();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_type.Text = "char";
            txt_size.Text = sizeof(char).ToString();
            txt_min.Text = (char.MinValue - '\0' ).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_type.Text = "unsigned int 16 bit";
            txt_size.Text = sizeof(UInt16).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_type.Text = "Sbyte";
            txt_size.Text = sizeof(SByte).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_type.Text = "Long";
            txt_size.Text = sizeof(long).ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_type.Text = "float";
            txt_size.Text = sizeof(float).ToString();
            txt_min.Text = float.MinValue.ToString();
            txt_max.Text = float.MaxValue.ToString();

        }
    }
}
