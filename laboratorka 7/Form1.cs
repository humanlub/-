using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        private ArrayPictures arrPic;
        public Form1()
        {
            InitializeComponent();
            int ind_image = 0;
            Image im_pic = (Image)Properties.Resources.ResourceManager.GetObject("Task_1");
            Bitmap bmp_pic = new Bitmap(im_pic);
            Size size_pic = new Size(pictureBox1.Width, pictureBox1.Height);
            arrPic = new ArrayPictures(pictureBox1, bmp_pic, size_pic, 3, 4);
            AssignPictures();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size pic_size = new Size(this.Size.Width - 20, this.Size.Height - 100);
            pictureBox1.Size = pic_size;
            arrPic.Set_Sizes(pic_size);
        }
        private void AssignPictures()
        {
            foreach (PictureBox pic in arrPic.Get_Pictures())
            {
                int index = (int)pic.Tag;
                pic.Click += new EventHandler(fragment_Click);
                pic.Visible = true;
            }
        }
        void fragment_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int index = (int)pic.Tag;
            if (Load.Checked)
            {
                LoadFragment(index);
            }
            else
            {
                SaveFragment(index);
            }

        }
        private void LoadFragment(int index)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "файлы картинок (*.bmp;*.jpg;*.jpeg;)|*.bmp;*.jpg;.jpeg|All files(*.*) | *.* ";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap pic_show = new Bitmap(openFileDialog.FileName);

                arrPic.change_bmp(index, pic_show);
            }
        }
        private void SaveFragment(int index)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "файлы картинок (*.bmp;*.jpg;*.jpeg;)|*.bmp;*.jpg;.jpeg|All files(*.*) | *.* "; 
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string str_file = saveFileDialog.FileName; 
                PictureBox pic = arrPic[index];
                pic.Image.Save(str_file);
            }
        }

    }
}