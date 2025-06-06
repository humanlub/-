using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private FormatOutputBox_GUI _OutputBox = new FormatOutputBox_GUI();
        private int? x= null;
        private int? y= null;
        private int _index = 0;

        private void input_SelectedIndexChanged(object sender, EventArgs e)
        {
            _index = input.SelectedIndex;
            _OutputBox.Invoke_Data(_index, ref pictureBox1, ref richTextBox_OutPut);
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            if (x != null && y != null)
            {
                _OutputBox.Execute_Data(x, y);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox1.Text, out value))
            {
                x = value; 
            }
            else
            {
                x = null;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox2.Text, out value))
            {
                y = value;
            }
            else
            {
                y = null;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            _OutputBox.Clear_Data();
            textBox2.Clear();
            textBox1.Clear();
            y = null;
            x = null;
            richTextBox_OutPut.Clear();
        }
    }
}


