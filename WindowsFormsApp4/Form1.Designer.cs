namespace WindowsFormsApp4
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
            this.ListBoxElements = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.RemoveSelectedElement = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.LabelEvents = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonAddElements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxElements
            // 
            this.ListBoxElements.FormattingEnabled = true;
            this.ListBoxElements.Items.AddRange(new object[] {
            ""});
            this.ListBoxElements.Location = new System.Drawing.Point(12, 12);
            this.ListBoxElements.Name = "ListBoxElements";
            this.ListBoxElements.Size = new System.Drawing.Size(247, 394);
            this.ListBoxElements.TabIndex = 0;
            this.ListBoxElements.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(274, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "<Введите текст для элемента списка >";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(392, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 168);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(392, 226);
            this.textBox3.TabIndex = 3;
            // 
            // RemoveSelectedElement
            // 
            this.RemoveSelectedElement.Location = new System.Drawing.Point(12, 412);
            this.RemoveSelectedElement.Name = "RemoveSelectedElement";
            this.RemoveSelectedElement.Size = new System.Drawing.Size(247, 23);
            this.RemoveSelectedElement.TabIndex = 4;
            this.RemoveSelectedElement.Text = "&Удалить выбранный элемент";
            this.RemoveSelectedElement.UseVisualStyleBackColor = true;
            this.RemoveSelectedElement.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(12, 441);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(247, 23);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "&Очистить список";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(280, 18);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(234, 13);
            this.Info.TabIndex = 6;
            this.Info.Text = "Информация о выбранном элементе списка";
            this.Info.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LabelEvents
            // 
            this.LabelEvents.AutoSize = true;
            this.LabelEvents.Location = new System.Drawing.Point(271, 151);
            this.LabelEvents.Name = "LabelEvents";
            this.LabelEvents.Size = new System.Drawing.Size(93, 13);
            this.LabelEvents.TabIndex = 7;
            this.LabelEvents.Text = "Событие списка:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "&Очистить лог событий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonAddElements
            // 
            this.ButtonAddElements.Location = new System.Drawing.Point(457, 119);
            this.ButtonAddElements.Name = "ButtonAddElements";
            this.ButtonAddElements.Size = new System.Drawing.Size(209, 23);
            this.ButtonAddElements.TabIndex = 9;
            this.ButtonAddElements.Text = "&Добавить элемент в список";
            this.ButtonAddElements.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 479);
            this.Controls.Add(this.ButtonAddElements);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LabelEvents);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.RemoveSelectedElement);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListBoxElements);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxElements;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button RemoveSelectedElement;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label LabelEvents;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButtonAddElements;
    }
}

