namespace WindowsFormsApp5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Clear2 = new System.Windows.Forms.Button();
            this.Sort2 = new System.Windows.Forms.Button();
            this.sortbox2 = new System.Windows.Forms.ComboBox();
            this.DublArrowleft = new System.Windows.Forms.Button();
            this.DoublArrowright = new System.Windows.Forms.Button();
            this.LeftArrow = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.search = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enterish = new System.Windows.Forms.TextBox();
            this.Clear1 = new System.Windows.Forms.Button();
            this.Sort1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sortbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Begin = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.RadioButton();
            this.numbers = new System.Windows.Forms.RadioButton();
            this.All = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.Clear2);
            this.panel1.Controls.Add(this.Sort2);
            this.panel1.Controls.Add(this.sortbox2);
            this.panel1.Controls.Add(this.DublArrowleft);
            this.panel1.Controls.Add(this.DoublArrowright);
            this.panel1.Controls.Add(this.LeftArrow);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.Right);
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Clear1);
            this.panel1.Controls.Add(this.Sort1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.sortbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 481);
            this.panel1.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(190, 278);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 22);
            this.Delete.TabIndex = 17;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(190, 249);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(118, 23);
            this.Add.TabIndex = 16;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Clear2
            // 
            this.Clear2.Location = new System.Drawing.Point(342, 278);
            this.Clear2.Name = "Clear2";
            this.Clear2.Size = new System.Drawing.Size(118, 22);
            this.Clear2.TabIndex = 15;
            this.Clear2.Text = "Очистить";
            this.Clear2.UseVisualStyleBackColor = true;
            this.Clear2.Click += new System.EventHandler(this.Clear2_Click);
            // 
            // Sort2
            // 
            this.Sort2.Location = new System.Drawing.Point(342, 249);
            this.Sort2.Name = "Sort2";
            this.Sort2.Size = new System.Drawing.Size(118, 23);
            this.Sort2.TabIndex = 14;
            this.Sort2.Text = "Сортировать";
            this.Sort2.UseVisualStyleBackColor = true;
            this.Sort2.Click += new System.EventHandler(this.Sort2_Click);
            // 
            // sortbox2
            // 
            this.sortbox2.FormattingEnabled = true;
            this.sortbox2.Items.AddRange(new object[] {
            "А-Я",
            "Я-А",
            "По длине строк (Возрастающая)",
            "По длине строк (Убывание)"});
            this.sortbox2.Location = new System.Drawing.Point(325, 38);
            this.sortbox2.Name = "sortbox2";
            this.sortbox2.Size = new System.Drawing.Size(149, 21);
            this.sortbox2.TabIndex = 13;
            this.sortbox2.Text = "Сортировка по..";
            // 
            // DublArrowleft
            // 
            this.DublArrowleft.Location = new System.Drawing.Point(193, 168);
            this.DublArrowleft.Name = "DublArrowleft";
            this.DublArrowleft.Size = new System.Drawing.Size(110, 28);
            this.DublArrowleft.TabIndex = 12;
            this.DublArrowleft.Text = "<<";
            this.DublArrowleft.UseVisualStyleBackColor = true;
            this.DublArrowleft.Click += new System.EventHandler(this.DublArrowleft_Click);
            // 
            // DoublArrowright
            // 
            this.DoublArrowright.Location = new System.Drawing.Point(193, 133);
            this.DoublArrowright.Name = "DoublArrowright";
            this.DoublArrowright.Size = new System.Drawing.Size(110, 29);
            this.DoublArrowright.TabIndex = 11;
            this.DoublArrowright.Text = ">>";
            this.DoublArrowright.UseVisualStyleBackColor = true;
            this.DoublArrowright.Click += new System.EventHandler(this.DoublArrowright_Click);
            // 
            // LeftArrow
            // 
            this.LeftArrow.Location = new System.Drawing.Point(193, 102);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(113, 25);
            this.LeftArrow.TabIndex = 10;
            this.LeftArrow.Text = "<";
            this.LeftArrow.UseVisualStyleBackColor = true;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(302, 373);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(131, 45);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(302, 424);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(134, 41);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(193, 70);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(110, 26);
            this.Right.TabIndex = 7;
            this.Right.Text = ">";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(325, 70);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(149, 173);
            this.listBox3.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.enterish);
            this.groupBox1.Location = new System.Drawing.Point(30, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(163, 52);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Раздел 1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(163, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Раздел 2";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(160, 100);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(83, 63);
            this.search.TabIndex = 3;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(13, 52);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(141, 108);
            this.listBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите исходное слово";
            // 
            // enterish
            // 
            this.enterish.Location = new System.Drawing.Point(14, 32);
            this.enterish.Name = "enterish";
            this.enterish.Size = new System.Drawing.Size(140, 20);
            this.enterish.TabIndex = 0;
            // 
            // Clear1
            // 
            this.Clear1.Location = new System.Drawing.Point(43, 278);
            this.Clear1.Name = "Clear1";
            this.Clear1.Size = new System.Drawing.Size(118, 22);
            this.Clear1.TabIndex = 4;
            this.Clear1.Text = "Очистить";
            this.Clear1.UseVisualStyleBackColor = true;
            this.Clear1.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sort1
            // 
            this.Sort1.Location = new System.Drawing.Point(43, 249);
            this.Sort1.Name = "Sort1";
            this.Sort1.Size = new System.Drawing.Size(118, 23);
            this.Sort1.TabIndex = 3;
            this.Sort1.Text = "Сортировать";
            this.Sort1.UseVisualStyleBackColor = true;
            this.Sort1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 173);
            this.listBox1.TabIndex = 2;
            // 
            // sortbox
            // 
            this.sortbox.FormattingEnabled = true;
            this.sortbox.Items.AddRange(new object[] {
            "А-Я",
            "Я-А",
            "По длине строк (Возрастающая)",
            "По длине строк (Убывание)"});
            this.sortbox.Location = new System.Drawing.Point(30, 38);
            this.sortbox.Name = "sortbox";
            this.sortbox.Size = new System.Drawing.Size(131, 21);
            this.sortbox.TabIndex = 1;
            this.sortbox.Text = "Сортировка по...";
            this.sortbox.SelectedIndexChanged += new System.EventHandler(this.sortbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Раздел 1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(501, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(235, 393);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Begin);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.numbers);
            this.groupBox2.Controls.Add(this.All);
            this.groupBox2.Location = new System.Drawing.Point(501, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор слов";
            // 
            // Begin
            // 
            this.Begin.Location = new System.Drawing.Point(155, 17);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(62, 52);
            this.Begin.TabIndex = 3;
            this.Begin.Text = "Начать";
            this.Begin.UseVisualStyleBackColor = true;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(6, 59);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(131, 17);
            this.email.TabIndex = 2;
            this.email.TabStop = true;
            this.email.Text = "Содержащие \"e-mail\"";
            this.email.UseVisualStyleBackColor = true;
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.Location = new System.Drawing.Point(6, 40);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(128, 17);
            this.numbers.TabIndex = 1;
            this.numbers.TabStop = true;
            this.numbers.Text = "Содержащие цифры";
            this.numbers.UseVisualStyleBackColor = true;
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Location = new System.Drawing.Point(6, 19);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(44, 17);
            this.All.TabIndex = 0;
            this.All.TabStop = true;
            this.All.Text = "Все";
            this.All.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.открытьToolStripMenuItem.Text = "Открыть ";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear1;
        private System.Windows.Forms.Button Sort1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox sortbox;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enterish;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button DublArrowleft;
        private System.Windows.Forms.Button DoublArrowright;
        private System.Windows.Forms.Button LeftArrow;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Clear2;
        private System.Windows.Forms.Button Sort2;
        private System.Windows.Forms.ComboBox sortbox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton All;
        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.RadioButton email;
        private System.Windows.Forms.RadioButton numbers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

