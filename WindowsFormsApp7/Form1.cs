using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace WindowsFormsApp7
{
    public partial class Form1: Form
    {
        private GameEngine engine;

        public Form1()
        {
            InitializeComponent();
            engine = new GameEngine(this);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FillCelRNum();
            int result = engine.SumMatchNum("panel1");
            if (result != 0)
            {
                PaintCell();
                label8.Visible = true;
                label8.Text = "+ " + result.ToString();
            }
            else { label8.Visible = false; PaintCell(); }
        }  
        private void FillCelRNum() 
        {

            string PanelName = "panel1";
            Control panelControl = this.Controls[PanelName];
            if (panelControl != null && panelControl is Panel panel) 
            {
              FillcellInControl(panelControl);
            }
            
            
        }
        private Random RandomNum = new Random();
        void FillcellInControl(Control parent) 
        {

            foreach(Control cellControl in parent.Controls)
            {
                if (cellControl is Label label && label.Name.StartsWith("Cell")) 
                {
 
                       label.Text = RandomNum.Next(1,8).ToString();
                    
                }
                if (cellControl.Controls.Count > 0) 
                {
                    FillcellInControl(cellControl);
                }
            }
        }
        private void PaintCell()
        {
            string PanelName = "panel1";
            Control panelControl = this.Controls[PanelName];
            if (panelControl != null && panelControl is Panel panel)
            {
                PaintWinCell(panelControl);
            }
        }
        void PaintWinCell(Control parent)
        {
            int result = engine.SumMatchNum("panel1");
            foreach (Control cellControl in parent.Controls)
            {
                if (result != 0)
                {
                    for (int i = 4; i <= 6; i++)
                    {
                        if (cellControl is Label label && label.Name.StartsWith("Cell" + i.ToString()))
                        {
                            label.ForeColor = Color.Red;
                        }
                    }
                }
                else 
                {
                    for (int i = 4; i <= 6; i++)
                    {
                        if (cellControl is Label label && label.Name.StartsWith("Cell" + i.ToString()))
                        {
                            label.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }


        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

