namespace ProgressBar
{
    partial class FormProgressBar
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.complete = new System.Windows.Forms.Label();
            this.PercentComplete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.progressStep = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressbar
            // 
            this.progressbar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressbar.Location = new System.Drawing.Point(12, 21);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(616, 23);
            this.progressbar.TabIndex = 0;
            // 
            // complete
            // 
            this.complete.AutoSize = true;
            this.complete.Location = new System.Drawing.Point(9, 47);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(67, 13);
            this.complete.TabIndex = 1;
            this.complete.Text = "Выполнено:";
            // 
            // PercentComplete
            // 
            this.PercentComplete.AutoSize = true;
            this.PercentComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.PercentComplete.Location = new System.Drawing.Point(82, 47);
            this.PercentComplete.Name = "PercentComplete";
            this.PercentComplete.Size = new System.Drawing.Size(16, 13);
            this.PercentComplete.TabIndex = 2;
            this.PercentComplete.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Статус:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.status.Location = new System.Drawing.Point(82, 69);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(14, 13);
            this.status.TabIndex = 4;
            this.status.Text = "?";
            // 
            // progressStep
            // 
            this.progressStep.AutoSize = true;
            this.progressStep.Location = new System.Drawing.Point(328, 111);
            this.progressStep.Name = "progressStep";
            this.progressStep.Size = new System.Drawing.Size(107, 13);
            this.progressStep.TabIndex = 5;
            this.progressStep.Text = "Шаг прогресс бара:";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(13, 106);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(130, 23);
            this.reset.TabIndex = 6;
            this.reset.Text = "&Сброс";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(149, 106);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(130, 23);
            this.stop.TabIndex = 7;
            this.stop.Text = "&Остановить";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(441, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 141);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.progressStep);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PercentComplete);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.progressbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormProgressBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Label complete;
        private System.Windows.Forms.Label PercentComplete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label progressStep;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

