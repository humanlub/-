namespace ProgressBarBackgroundWorker
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Найденные файлы", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBoxDrives = new System.Windows.Forms.ComboBox();
            this.SearchPathTextBox = new System.Windows.Forms.TextBox();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectSearchDirectory = new System.Windows.Forms.Button();
            this.StartSearch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Main = new System.Windows.Forms.ProgressBar();
            this.BWSearchTime = new System.ComponentModel.BackgroundWorker();
            this.BWSearchFiles = new System.ComponentModel.BackgroundWorker();
            this.FBDSelectSearchDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диск для поиска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Путь для поиска:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Полное имя файла, часть имени файла или часть пути, содержащего файл:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Прогресс:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Список найденых файлов:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(774, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "0";
            // 
            // ComboBoxDrives
            // 
            this.ComboBoxDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDrives.FormattingEnabled = true;
            this.ComboBoxDrives.Location = new System.Drawing.Point(126, 6);
            this.ComboBoxDrives.Name = "ComboBoxDrives";
            this.ComboBoxDrives.Size = new System.Drawing.Size(661, 21);
            this.ComboBoxDrives.TabIndex = 6;
            this.toolTip1.SetToolTip(this.ComboBoxDrives, "Указывает на системный диск, в ");
            this.ComboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDrives_SelectedIndexChanged);
            // 
            // SearchPathTextBox
            // 
            this.SearchPathTextBox.Location = new System.Drawing.Point(15, 57);
            this.SearchPathTextBox.Name = "SearchPathTextBox";
            this.SearchPathTextBox.ReadOnly = true;
            this.SearchPathTextBox.Size = new System.Drawing.Size(632, 20);
            this.SearchPathTextBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.SearchPathTextBox, "Отображает путь, в котором будет ");
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(15, 107);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(632, 20);
            this.FileNameTextBox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.FileNameTextBox, "1) png ");
            this.FileNameTextBox.TextChanged += new System.EventHandler(this.FileNameTextBox_TextChanged);
            // 
            // SelectSearchDirectory
            // 
            this.SelectSearchDirectory.Location = new System.Drawing.Point(653, 55);
            this.SelectSearchDirectory.Name = "SelectSearchDirectory";
            this.SelectSearchDirectory.Size = new System.Drawing.Size(135, 23);
            this.SelectSearchDirectory.TabIndex = 9;
            this.SelectSearchDirectory.Text = "&Обзор";
            this.toolTip1.SetToolTip(this.SelectSearchDirectory, "Выберите директорию, в которой ");
            this.SelectSearchDirectory.UseVisualStyleBackColor = true;
            this.SelectSearchDirectory.Click += new System.EventHandler(this.SelectSearchDirectory_Click);
            // 
            // StartSearch
            // 
            this.StartSearch.Location = new System.Drawing.Point(653, 105);
            this.StartSearch.Name = "StartSearch";
            this.StartSearch.Size = new System.Drawing.Size(135, 23);
            this.StartSearch.TabIndex = 10;
            this.StartSearch.Text = "&Начать поиск";
            this.toolTip1.SetToolTip(this.StartSearch, "Нажмите для начала поиска или ");
            this.StartSearch.UseVisualStyleBackColor = true;
            this.StartSearch.Click += new System.EventHandler(this.StartSearch_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FileSize});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup2.Header = "Найденные файлы";
            listViewGroup2.Name = "ViewFoundFiles";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 172);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(773, 270);
            this.listView1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.listView1, "В списке будут отражены результаты ");
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // FileName
            // 
            this.FileName.Text = "Имя файла";
            this.FileName.Width = 650;
            // 
            // FileSize
            // 
            this.FileSize.Text = "Размер файла, байт";
            this.FileSize.Width = 115;
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(15, 470);
            this.Main.MarqueeAnimationSpeed = 30;
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(773, 23);
            this.Main.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Main.TabIndex = 12;
            this.toolTip1.SetToolTip(this.Main, "Отображает ход выполнения операции ");
            // 
            // BWSearchTime
            // 
            this.BWSearchTime.WorkerReportsProgress = true;
            this.BWSearchTime.WorkerSupportsCancellation = true;
            this.BWSearchTime.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWSearchTime_DoWork);
            this.BWSearchTime.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWSearchTime_ProgressChanged);
            this.BWSearchTime.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWSearchTime_RunWorkerCompleted);
            // 
            // BWSearchFiles
            // 
            this.BWSearchFiles.WorkerReportsProgress = true;
            this.BWSearchFiles.WorkerSupportsCancellation = true;
            this.BWSearchFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWSearchFiles_DoWork);
            this.BWSearchFiles.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWSearchFiles_ProgressChanged);
            this.BWSearchFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWSearchFiles_RunWorkerCompleted);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 1000;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка:";
            // 
            // Form1
            // 
            this.AcceptButton = this.StartSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.StartSearch);
            this.Controls.Add(this.SelectSearchDirectory);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.SearchPathTextBox);
            this.Controls.Add(this.ComboBoxDrives);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBoxDrives;
        private System.Windows.Forms.TextBox SearchPathTextBox;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Button SelectSearchDirectory;
        private System.Windows.Forms.Button StartSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FileSize;
        private System.Windows.Forms.ProgressBar Main;
        private System.ComponentModel.BackgroundWorker BWSearchTime;
        private System.ComponentModel.BackgroundWorker BWSearchFiles;
        private System.Windows.Forms.FolderBrowserDialog FBDSelectSearchDirectory;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

