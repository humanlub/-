using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxElements.Items.Add("Первый элемент списка");
            ListBoxElements.Items.Add("Второй элемент списка");
            ListBoxElements.Items.Add("Третий элемент списка");
            ListBoxElements.Items.Add("Четвертый элемент списка");
            ListBoxElements.Items.Add("Пятый элемент списка");
            UpdateSelectedElementsInfo();
            ClearText();
            EnableDisableButtonAddElements();
        }
        private void UpdateSelectedElementsInfo()
        {
            if (ListBoxElements.SelectedIndex == -1)
            {
                Info.Text = "Не выбран ни один элемент списка";
                return;
            }
            string selectedItem = (string)ListBoxElements.SelectedItem;
            textBox2.Text = "Выбран" + selectedItem;
        }
        private void EnableDisableButtonAddElements() 
        {
            ButtonAddElements.Enabled = textBox1.Text!=""&&textBox1.ForeColor !=Color.LightCyan;
        }
        private void AddLog(string logMessage)
        {
            textBox3.Text += logMessage + "\r\n";
        }
        private void ClearText() 
        {
            textBox1.ForeColor = Color.DarkCyan ;
            textBox1.Text = "<Введите текст для элемента списка...>";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveSelectedElement.Enabled = ListBoxElements.Items.Count > 0 && ListBoxElements.SelectedIndex != null;
            if (ListBoxElements.SelectedIndex != null) 
            {
                AddLog("Удалён: " + ListBoxElements.SelectedItem);
                ListBoxElements.Items.Remove(ListBoxElements.SelectedItem);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.LightCyan) 
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clear.Enabled = ListBoxElements.Items.Count > 0;
            ListBoxElements.Items.Clear();
            ClearText();
            EnableDisableButtonAddElements();

        }


    }
}
