using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class FormProgressBar: Form
    {
        class ProgressStep 
        {
            public string Steptext { get; set; }
            public int Stepvalue { get; set; }
            public ProgressStep(string steptext, int stepvalue)
            {
                Steptext = steptext;
                Stepvalue = stepvalue;
            }
            public override string ToString()
            {
                return Steptext;
            }
        }
        public FormProgressBar()
        {
            InitializeComponent();
        }

        private void FormProgressBar_Load(object sender, EventArgs e)
        {
            UpdProgressBar();
            Fill();

        }
        private void Fill()
        {
            comboBox1.Items.Add(new ProgressStep("1%", 1));
            comboBox1.Items.Add(new ProgressStep("20%", 20));
            comboBox1.Items.Add(new ProgressStep("30%", 30));
            comboBox1.Items.Add(new ProgressStep("40%", 40));
            comboBox1.Items.Add(new ProgressStep("50%", 50));
        }
        private void UpdProgressBar() 
        {
            PercentComplete.Text = progressbar.Value + "%";
            if (progressbar.Value >= 0 && progressbar.Value < 20)
            {
                status.Text = "Инициализация";
            }
            else if (progressbar.Value >= 20 && progressbar.Value < 40)
            {
                status.Text = "Подготовка примера";
            }
            else if (progressbar.Value >= 40 && progressbar.Value < 60)
            {
                status.Text = "Выполнение задачи #1";
            }
            else if (progressbar.Value >= 60 && progressbar.Value < 80)
            {
                status.Text = "Выполнение задачи #2";
            }
            else if (progressbar.Value >= 80 && progressbar.Value < 100)
            {
                status.Text = "Почти готово";
            }
            else 
            {
                status.Text = "Выполнено";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressbar.PerformStep();
            UpdProgressBar();
            stop.Enabled = progressbar.Value != 100;
            if (progressbar.Value >= 100) { timer1.Stop(); }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            progressbar.Value = 0;
            UpdProgressBar();
            if (!timer1.Enabled) 
            {
                timer1.Start();
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                stop.Text = "&Продолжить";
            }
            else 
            {
                timer1.Start();
                stop.Text = "&Остановить";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) 
            {
                ProgressStep step = (ProgressStep)comboBox1.SelectedItem;
                progressbar.Step = step.Stepvalue;
            }
        }
    }
}
