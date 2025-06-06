using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1: Form
    {
        private bool flag_access = true;
        private readonly int[] paramValueDef = { 10, 9, 8 };
        private IEvaluate[] evalRef = { null, null, null };
        public Form1()
        {
            InitializeComponent();
            evalRef[0] = new Class1();
            evalRef[1] = new Class2();
            evalRef[2] = new Class3();
            comboBox_TaskNum.SelectedIndex = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_TaskNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!flag_access)
            {
                return;
            }
            int ind = comboBox_TaskNum.SelectedIndex;
            evalRef[ind].Invoke_Variant(ind, paramValueDef[ind]);
            textBox_InputValue.Text = paramValueDef[ind].ToString();
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("Task_" + (ind + 1).ToString());
        }

        private void button_EvaluateVariant_Click(object sender, EventArgs e)
        {
            if (!flag_access) return;
            int ind = comboBox_TaskNum.SelectedIndex; 
            string str_out = evalRef[ind].Execute_Variant();
            label2.Text = str_out;
        }

        private void textBox_InputValue_TextChanged(object sender, EventArgs e)
        {
            if (!flag_access) 
            {
                return ;
            }
            int ind = comboBox_TaskNum.SelectedIndex;
            string str_num = textBox_InputValue.Text;
            evalRef[ind].ParamValue = Int32.Parse(str_num);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        public class CustomVScrollBar : VScrollBar
        {
            public int InvertedValue
            {
                get
                {
                    int offset = this.Value - this.Minimum;
                    return this.Maximum - offset;
                }
                set
                {
                    int offset = this.Maximum - value;
                    this.Value = this.Minimum + offset;
                }
            }
        }

        private void button_EvaluateAllDefault_Click(object sender, EventArgs e)
        {
            
            int N = 10;

            // Задание 2: значение по умолчанию N + 1
            Class2 task2 = new Class2();
            task2.Invoke_Variant(2, N + 1);
            string resultTask2 = task2.Execute_Variant();

            // Задание 3: значение по умолчанию N + 2
            Class3 task3 = new Class3();
            task3.Invoke_Variant(3, N + 2);
            string resultTask3 = task3.Execute_Variant().ToString();

            MessageBox.Show(resultTask2 + "\n" + resultTask3);
        }
    
    }
}
