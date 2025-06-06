using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAta
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 4;
            int[,] a = new int[3, 4];
            int i, j;
            Random rnd = new Random();
            for (i = 0; i < 3; i++)
            {
                for ( j = 0; j < 4; j++)
                {
                    a[i,j] = rnd.Next(0,100);
                }
            }
            for (i = 0; i < 3; i++) 
            {
                for (j = 0; j < 4; j++) 
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            }
            //int m = int.MaxValue;
            //
            for (i = 0; i < 3; i++) 
            {
                int m = a[i, 0];
                for (j = 1; j < 4; j++)
                { 
                    if (a[i,j] < m) 
                        m = a[i,j]; 
                }             
               textBox1.Text += Convert.ToString(m)+", ";
                
            }
            
        }
    }
}
