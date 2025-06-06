namespace lab10
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
            this.button_Close = new System.Windows.Forms.Button();
            this.button_EvaluateAllDefault = new System.Windows.Forms.Button();
            this.button_EvaluateVariant = new System.Windows.Forms.Button();
            this.comboBox_TaskNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_InputValue = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(12, 169);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(156, 39);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_EvaluateAllDefault
            // 
            this.button_EvaluateAllDefault.Location = new System.Drawing.Point(12, 124);
            this.button_EvaluateAllDefault.Name = "button_EvaluateAllDefault";
            this.button_EvaluateAllDefault.Size = new System.Drawing.Size(156, 39);
            this.button_EvaluateAllDefault.TabIndex = 1;
            this.button_EvaluateAllDefault.Text = "Все расчеты со значениями по умолчанию";
            this.button_EvaluateAllDefault.UseVisualStyleBackColor = true;
            this.button_EvaluateAllDefault.Click += new System.EventHandler(this.button_EvaluateAllDefault_Click);
            // 
            // button_EvaluateVariant
            // 
            this.button_EvaluateVariant.Location = new System.Drawing.Point(12, 79);
            this.button_EvaluateVariant.Name = "button_EvaluateVariant";
            this.button_EvaluateVariant.Size = new System.Drawing.Size(156, 39);
            this.button_EvaluateVariant.TabIndex = 2;
            this.button_EvaluateVariant.Text = "Выполнить расчет";
            this.button_EvaluateVariant.UseVisualStyleBackColor = true;
            this.button_EvaluateVariant.Click += new System.EventHandler(this.button_EvaluateVariant_Click);
            // 
            // comboBox_TaskNum
            // 
            this.comboBox_TaskNum.FormattingEnabled = true;
            this.comboBox_TaskNum.Items.AddRange(new object[] {
            "Задание 1",
            "Задание 2",
            "Задание 3"});
            this.comboBox_TaskNum.Location = new System.Drawing.Point(25, 41);
            this.comboBox_TaskNum.Name = "comboBox_TaskNum";
            this.comboBox_TaskNum.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TaskNum.TabIndex = 3;
            this.comboBox_TaskNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_TaskNum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите номер задания";
            // 
            // textBox_InputValue
            // 
            this.textBox_InputValue.Location = new System.Drawing.Point(82, 122);
            this.textBox_InputValue.Name = "textBox_InputValue";
            this.textBox_InputValue.ReadOnly = true;
            this.textBox_InputValue.Size = new System.Drawing.Size(100, 20);
            this.textBox_InputValue.TabIndex = 5;
            this.textBox_InputValue.TextChanged += new System.EventHandler(this.textBox_InputValue_TextChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(185, 119);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(52, 26);
            this.vScrollBar1.TabIndex = 6;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 100);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 56);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Значение n:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Controls.Add(this.textBox_InputValue);
            this.groupBox1.Location = new System.Drawing.Point(181, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 224);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 227);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_TaskNum);
            this.Controls.Add(this.button_EvaluateVariant);
            this.Controls.Add(this.button_EvaluateAllDefault);
            this.Controls.Add(this.button_Close);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_EvaluateAllDefault;
        private System.Windows.Forms.Button button_EvaluateVariant;
        private System.Windows.Forms.ComboBox comboBox_TaskNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_InputValue;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

