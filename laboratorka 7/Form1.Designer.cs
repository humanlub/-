namespace lab7
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveAs = new System.Windows.Forms.RadioButton();
            this.Load = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(480, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 280);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SaveAs
            // 
            this.SaveAs.AutoSize = true;
            this.SaveAs.Location = new System.Drawing.Point(12, 298);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(152, 17);
            this.SaveAs.TabIndex = 1;
            this.SaveAs.TabStop = true;
            this.SaveAs.Text = "Сохранить фрагмент как";
            this.SaveAs.UseVisualStyleBackColor = true;
            // 
            // Load
            // 
            this.Load.AutoSize = true;
            this.Load.Location = new System.Drawing.Point(186, 298);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(130, 17);
            this.Load.TabIndex = 2;
            this.Load.TabStop = true;
            this.Load.Text = "Загрузить фрагмент\r\n";
            this.Load.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 333);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load.Click += new System.EventHandler(this.fragment_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton SaveAs;
        private System.Windows.Forms.RadioButton Load;
    }
}

