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
            label8.Visible = true;
            label8.Text = "+ " + result.ToString();
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
 
                       label.Text = RandomNum.Next(1,7).ToString();
                    
                }
                if (cellControl.Controls.Count > 0) 
                {
                    FillcellInControl(cellControl);
                }
            }
        }
    }
}

