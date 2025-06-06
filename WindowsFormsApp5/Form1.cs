using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sortbox.SelectedIndex == 0)
            {
                List<string> items = listBox1.Items.Cast<string>().ToList();
                items.Sort();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(items.ToArray());
            }
            if (sortbox.SelectedIndex == 1) 
            {
                List<string> items = listBox1.Items.Cast<string>().ToList();
                items.Sort();
                items.Reverse();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(items.ToArray());
            }
            if (sortbox.SelectedIndex == 2) 
            {
                List<string> items = listBox1.Items.Cast<string>().ToList();
                items = items.OrderBy(s => s.Length).ToList();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(items.ToArray());
            }
            if (sortbox.SelectedIndex == 3) 
            {
                List<string> items = listBox1.Items.Cast<string>().ToList();
                items = items.OrderByDescending(s => s.Length).ToList();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(items.ToArray());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string find = enterish.Text;
            if (checkBox1.Checked) 
            {
                foreach (string strings in listBox1.Items) 
                {
                    if (strings.Contains(find)) 
                    {
                        listBox2.Items.Add(strings);
                    }
                }
            }
            if (checkBox2.Checked) 
            {
                foreach (string strings in listBox3.Items) 
                {
                    if (strings.Contains(find)) 
                    {
                        listBox2.Items.Add(strings);
                    }
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            richTextBox1.Text = string.Empty;
            All = null;
            email = null;
            numbers = null;
            checkBox1 = null;
            checkBox2 = null;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(OpenDlg.FileName,Encoding.Default);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++) 
                {
                    writer.WriteLine((string)listBox2.Items[i]);
                }
                writer.Close();
            }
            SaveDlg.Dispose();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информация о приложении и разработчике");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Begin_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();

            string[] strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in strings)
            {
                string str = s.Trim();
                if (str == String.Empty) continue;
                if (All.Checked)listBox1.Items.Add(str);
                if (numbers.Checked) 
                {
                    if (Regex.IsMatch(str,@"\d")) 
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (email.Checked) 
                {
                    if (Regex.IsMatch(str, @"\w+@\w+\.\w+")) 
                    {
                        listBox1.Items.Add(str);
                    }
                }
                listBox1.EndUpdate();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form1 Addf = new Form1();
            Addf.Owner = this;
            Addf.ShowDialog();
            Form1 Main = this.Owner as Form1;
            if (enterish.Text != " ") 
            {
                if (this.All.Checked == true)
                {
                    Main.listBox1.Items.Add(this.enterish.Text);

                }
                else 
                {
                    Main.listBox2.Items.Add(this.enterish.Text);
                    this.Close();
                }
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            listBox3.BeginUpdate();
            foreach (object Item in listBox1.SelectedItems)
            {
                listBox3.Items.Add(Item);
            }
            listBox3.EndUpdate();
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            foreach (object Item in listBox3.SelectedItems)
            {
                listBox1.Items.Add(Item);
            }
            listBox1.EndUpdate();
        }

        private void DoublArrowright_Click(object sender, EventArgs e)
        {
            listBox3.BeginUpdate();
            foreach (object Item in listBox1.Items) 
            {
                listBox3.Items.Add(Item);
            }
            listBox3.EndUpdate();
        }

        private void DublArrowleft_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            foreach (object Item in listBox3.Items) 
            {
                listBox1.Items.Add(Item);
            }
            listBox1.EndUpdate();
        }
        private void sortbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sort2_Click(object sender, EventArgs e)
        {
            if (sortbox2.SelectedIndex == 0)
            {
                List<string> items = listBox3.Items.Cast<string>().ToList();
                items.Sort();
                listBox3.Items.Clear();
                listBox3.Items.AddRange(items.ToArray());
            }
            if (sortbox2.SelectedIndex == 1)
            {
                List<string> items = listBox3.Items.Cast<string>().ToList();
                items.Sort();
                items.Reverse();
                listBox3.Items.Clear();
                listBox3.Items.AddRange(items.ToArray());
            }
            if (sortbox2.SelectedIndex == 2)
            {
                List<string> items = listBox3.Items.Cast<string>().ToList();
                items = items.OrderBy(s => s.Length).ToList();
                listBox3.Items.Clear();
                listBox3.Items.AddRange(items.ToArray());
            }
            if (sortbox2.SelectedIndex == 3)
            {
                List<string> items = listBox3.Items.Cast<string>().ToList();
                items = items.OrderByDescending(s => s.Length).ToList();
                listBox3.Items.Clear();
                listBox3.Items.AddRange(items.ToArray());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Clear2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear ();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (object item in listBox1.Items) 
            {
                listBox1.Items.Clear();
            }
            foreach (object item in listBox3.Items) 
            {
                listBox3.Items.Clear();
            }
        }
    }
}
