using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgressBarBackgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label6.Visible = false;
            Main.Visible = false;
            this.DoubleBuffered = true;

            LoadAvailableDrivesInfo();
            UpdateSearchDirectoryFromSelectedDrive();
        }
        class FileSearchInfo
        {
            public long FilesTotalCount { get; set; } = 0;
            public long FilesProcessedCount { get; set; } = 0;
            public string SearchDirectory { get; set; }
            public long FilesFound { get; set; } = 0;
            public string FileNameMask { get; set; } = "";
            public List<string> FoundFiles = new List<string>();
        }
        enum BackgroundWorkerMode
        {
            Estimate,
            Search
        }
        public bool IsSearchRunning { get; set; } = false;
        private FileSearchInfo FileSearchInfoHolder { get; set; } = new FileSearchInfo();
        private void SetIsSearchRunningAndUpdateButtonStartState(bool isRunning)
        {
            if (isRunning)
            {
                StartSearch.Text = "&Прервать";
            }
            else
            {
                StartSearch.Text = "&Начать поиск";
                StartSearch.Enabled = true;
            }
            IsSearchRunning = isRunning;
        }
        private void StartSelectedFileUsingShellExecute(string pathToFile)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = pathToFile;
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
        private void UpdateSearchPathReadonlyTextBox(string searchPath)
        {
            if (!searchPath.Equals(SearchPathTextBox.Text) && FileSearchInfoHolder.FilesTotalCount > 0)
            {
                FileSearchInfoHolder.FilesTotalCount = 0;
            }
            SearchPathTextBox.Text = searchPath;
        }
        private void SelectDriveBySearchPath(string searchPath)
        {
            int commaSlashPosition = searchPath.IndexOf(":\\");
            if (commaSlashPosition >= 0)
            {
                string driveLetterFromPath = searchPath.Substring(0, commaSlashPosition + 2);

                foreach (var item in ComboBoxDrives.Items)
                {
                    if (item is DriveInfoItem driveInfoItem)
                    {
                        if (driveInfoItem.DriveName.Equals(driveLetterFromPath))
                        {
                            ComboBoxDrives.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка: невозможно найти диск, соответствующий выбранному пути", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateSearchDirectoryFromSelectedDrive()
        {
            FileSearchInfoHolder.SearchDirectory = (ComboBoxDrives.SelectedItem as DriveInfoItem).DriveName;

            UpdateSearchPathReadonlyTextBox(FileSearchInfoHolder.SearchDirectory);
        }
        private void LoadAvailableDrivesInfo()
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach (var driveInfo in driveInfos)
            {
                ComboBoxDrives.Items.Add(new DriveInfoItem(driveInfo));
            }
            ComboBoxDrives.SelectedIndex = 0;
        }
        private void StartSearchFilesByFileName()
        {
            label4.Text = "Поиск файла по маске *" + FileSearchInfoHolder.FileNameMask + "* в каталоге '" + FileSearchInfoHolder.SearchDirectory + "'...";
            label6.Visible = false;
            Main.Style = ProgressBarStyle.Continuous;
            FileSearchInfoHolder.FilesFound = 0;
            FileSearchInfoHolder.FilesProcessedCount = 0;
            SetIsSearchRunningAndUpdateButtonStartState(true);
            BWSearchFiles.RunWorkerAsync(FileSearchInfoHolder);
        }
        private void CalculateFilesCountRecursively(string parentDirectory, BackgroundWorkerMode workerMode, FileSearchInfo fileInfoHolder)
        {
            try
            {
                IEnumerable<string> subdirectories = Directory.EnumerateDirectories(parentDirectory, "*", SearchOption.TopDirectoryOnly);
                IEnumerable<string> files = Directory.EnumerateFiles(parentDirectory);

                if (workerMode == BackgroundWorkerMode.Estimate)
                {
                    if (BWSearchTime.CancellationPending)
                    {
                        return;
                    }

                    fileInfoHolder.FilesTotalCount += files.LongCount();
                    BWSearchTime.ReportProgress(10);
                }
                else if (workerMode == BackgroundWorkerMode.Search)
                {
                    if (BWSearchFiles.CancellationPending)
                    {
                        return;
                    }

                    foreach (string file in files)
                    {
                        if (file.Contains(fileInfoHolder.FileNameMask))
                        {
                            fileInfoHolder.FoundFiles.Add(file);
                            FileSearchInfoHolder.FilesFound++;
                        }
                    }
                    List<string> foundFiles = new List<string>(fileInfoHolder.FoundFiles);

                    fileInfoHolder.FilesProcessedCount += files.LongCount();
                    int progress = (int)(fileInfoHolder.FilesProcessedCount * 100 / fileInfoHolder.FilesTotalCount);
                    BWSearchFiles.ReportProgress(progress, foundFiles);
                    fileInfoHolder.FoundFiles.Clear();
                }
                if (subdirectories.LongCount() > 0)
                {
                    foreach (string subdirectory in subdirectories)
                    {
                        CalculateFilesCountRecursively(subdirectory, workerMode, fileInfoHolder);
                    }
                }
                if (subdirectories.LongCount() > 0)
                {
                    foreach (string subdirectory in subdirectories)
                    {
                        CalculateFilesCountRecursively(subdirectory, workerMode,
                        fileInfoHolder);
                    }
                }

            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {

            }
            catch (DirectoryNotFoundException directoryNotFoundException)
            {

            }
            catch (Exception otherException)
            {

            }

        }

        private void BWSearchTime_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is FileSearchInfo fileInfo)
            {
                if (BWSearchTime.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {

                    CalculateFilesCountRecursively(FileSearchInfoHolder.SearchDirectory,
                    BackgroundWorkerMode.Estimate, fileInfo);
                    if (BWSearchTime.CancellationPending)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void BWSearchFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is FileSearchInfo fileInfo)
            {
                if (BWSearchFiles.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {

                    CalculateFilesCountRecursively(FileSearchInfoHolder.SearchDirectory,
                    BackgroundWorkerMode.Search, fileInfo);
                    if (BWSearchFiles.CancellationPending)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void BWSearchTime_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                SetIsSearchRunningAndUpdateButtonStartState(false);

                label4.Text = "Оценка времени поиска была прервана.";
                FileSearchInfoHolder.FilesTotalCount = 0;
                FileSearchInfoHolder.FilesFound = 0;
                Main.Visible = false;
                label6.Text = "0";
                label6.Visible = false;
            }
            else { StartSearchFilesByFileName(); }
        }

        private void BWSearchFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label4.Text = "Операция поиска прервана";
                Main.Visible = false;
                label6.Text = "0";
            }
            else
            {
                label4.Text = "Поиск по маске *" + FileSearchInfoHolder.FileNameMask + "* в каталоге'" + FileSearchInfoHolder.SearchDirectory + "'Завершён. Найдено файлов: ";
                label6.Left = label4.Right + 10;
                label6.Text = FileSearchInfoHolder.FoundFiles.ToString();
                label6.Visible = true;
            }
        }

        private void BWSearchTime_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label6.Text = FileSearchInfoHolder.FilesTotalCount.ToString();
        }

        private void BWSearchFiles_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Main.Value = e.ProgressPercentage;
            List<string> foundFiles = (List<string>)e.UserState;

            ListViewGroup group = listView1.Groups["listViewGroupFiles"];

            foreach (string fileName in foundFiles)
            {
                long fileSizeInBytes = -1;
                try
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    fileSizeInBytes = fileInfo.Length;
                }
                catch (FileNotFoundException fileNotFoundException) { }
                ListViewItem value = new ListViewItem(new string[] { fileName, fileSizeInBytes.ToString() }, 0, group);
            }
            FileSearchInfoHolder.FoundFiles.Clear();
        }

        private void FileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            StartSearch.Enabled = !"".Equals(FileNameTextBox.Text.Trim());
        }

        private void StartSearch_Click(object sender, EventArgs e)
        {
            if (IsSearchRunning)
            {
                StartSearch.Enabled = false;
                if (BWSearchTime.IsBusy)
                {
                    BWSearchTime.CancelAsync();
                }
                if (BWSearchFiles.IsBusy)
                {
                    BWSearchFiles.CancelAsync();
                }
            }
            else
            {
                FileSearchInfoHolder.FileNameMask = FileName.Text;
                Main.Value = 0;
                listView1.Groups.Clear();
                listView1.Groups.Add(new ListViewGroup("listViewGroupFiles", "Найденные файлы"));

                FileSearchInfoHolder.FoundFiles.Clear();

                Main.Visible = true;

                if (FileSearchInfoHolder.FilesTotalCount == 0)
                {
                    Main.Style = ProgressBarStyle.Marquee;
                    label4.Text = "Подсчёт количества файлов в системе и оценка примерного времени... Найдено файлов: ";
                    label4.Visible = true;
                    label6.Visible = true;
                    label6.Left = label4.Right + 10;
                    SetIsSearchRunningAndUpdateButtonStartState(true);

                    BWSearchTime.RunWorkerAsync(FileSearchInfoHolder);
                }
                else
                {
                    StartSearchFilesByFileName();
                }
            }
        }

        private void SelectSearchDirectory_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = FBDSelectSearchDirectory.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string selectedPath = FBDSelectSearchDirectory.SelectedPath;
                if (!selectedPath.EndsWith("\\"))
                {
                    selectedPath += "\\";
                }
                FileSearchInfoHolder.SearchDirectory = selectedPath;
                UpdateSearchPathReadonlyTextBox(selectedPath);
                SelectDriveBySearchPath(selectedPath);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            var selectedItems = listView1.SelectedItems;
            if (selectedItems.Count > 0)
            {
                var selectedItem = selectedItems[0];
                StartSelectedFileUsingShellExecute(selectedItem.Text);
            }
        }

        private void ComboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ComboBoxDrives.SelectedItem;
            if (selectedItem is DriveInfoItem driveInfoItem)
            {
                string selectedPath = driveInfoItem.DriveName;
                FileSearchInfoHolder.SearchDirectory = selectedPath;
                UpdateSearchPathReadonlyTextBox(selectedPath);
            }
        }
    }
}
