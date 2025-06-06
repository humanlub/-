using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

namespace lab7
{
    class ArrayPictures
    {
        private Bitmap Bmp_picture;
        private Size Size_picture;
        private PictureBox[] Pictures = null;
        private int Count_str;
        private int Count_col;

        public ArrayPictures(Control parent_control, Bitmap bmp_picture, Size size_picture,
            int count_str, int count_col)
        {
            Count_str = count_str;
            Size_picture = size_picture;
            Count_col = count_col;
            Pictures = new PictureBox[count_str * count_col];
            Bmp_picture = bmp_picture;
            for (int w = 0; w < Count_col; w++)
            {
                for (int h = 0; h < count_str; h++)
                {
                    int index = Get_Real_Index(w, h);
                    Pictures[index] = new PictureBox();
                    Pictures[index].Name = "pic_" + w.ToString() + "_" + w.ToString();
                    Pictures[index].Parent = parent_control;
                    Pictures[index].BorderStyle = BorderStyle.FixedSingle;
                    Pictures[index].SizeMode = PictureBoxSizeMode.StretchImage;
                    Pictures[index].Tag = (int)index;
                }
                Set_Sizes(size_picture);
            }

        }
        public void change_bmp(int index, Bitmap bmp_change)
        {
            int w_bmp = Bmp_picture.Width / Count_col;
            int h_bmp = Bmp_picture.Height / Count_str;
            int index_str = StrIndex(index);
            int index_col = ColIndex(index);
            RectangleF rect_temp = new RectangleF(index_str * w_bmp, index_col * h_bmp, w_bmp, h_bmp);
            Graphics gr = Graphics.FromImage(Bmp_picture);
            gr.DrawImage(bmp_change, rect_temp);

            Set_Sizes(Size_picture);
        }
        public void Swap_Bmp(int index1, int index2)
        {
            int w_bmp = Bmp_picture.Width / Count_col;
            int h_bmp = Bmp_picture.Height / Count_str;
            int index_1_string = StrIndex(index1);
            int index_1_column = ColIndex(index1);
            RectangleF rect_first = new RectangleF(index_1_string * w_bmp, index_1_column * h_bmp, w_bmp, h_bmp);
            Bitmap bmp_first = Bmp_picture.Clone(rect_first, Bmp_picture.PixelFormat);
            int index_2_string = StrIndex(index2);
            int index_2_column = ColIndex(index2);
            RectangleF rect_second = new RectangleF(index_2_string * w_bmp, index_2_column * h_bmp, w_bmp, h_bmp);
            Bitmap bmp_second = Bmp_picture.Clone(rect_second, Bmp_picture.PixelFormat);
            Graphics gr = Graphics.FromImage(Bmp_picture);
            gr.DrawImage(bmp_first, rect_second);
            gr.DrawImage(bmp_second, rect_first);
            Set_Sizes(Size_picture);
        }
        public void Set_Sizes(Size im_size)
        {
            Size_picture = im_size;
            int w = Size_picture.Width / Count_col;
            int h = Size_picture.Height / Count_str;
            int w_bmp = Bmp_picture.Width / Count_col;
            int h_bmp = Bmp_picture.Height / Count_str;
            Bitmap bmp_temp;
            RectangleF rect_temp;
            for (int i = 0; i < Count_col; i++)
                for (int j = 0; j < Count_str; j++)
                {
                    rect_temp = new RectangleF(i * w_bmp, j * h_bmp, w_bmp, h_bmp);
                    bmp_temp = Bmp_picture.Clone(rect_temp, Bmp_picture.PixelFormat);
                    int index = Get_Real_Index(i, j);
                    Pictures[index].Image = bmp_temp;
                    Pictures[index].Width = w;
                    Pictures[index].Height = h;
                    Pictures[index].Left = i * w;
                    Pictures[index].Top = j * h;
                    Pictures[index].BorderStyle = BorderStyle.FixedSingle;
                    Pictures[index].SizeMode = PictureBoxSizeMode.StretchImage;
                    Pictures[index].Refresh();
                }
        }
        public IEnumerable<PictureBox> Get_Pictures()
        {
            int count = Count_col * Count_str;
            for (int i = 0; i < count; i++)
            {
                if (Pictures != null)
                {
                    yield return Pictures[i];
                }
            }
        }
        public int StrIndex(int real_index)
        {
            int ind_string = real_index / Count_str;
            return ind_string;
        }

        public int ColIndex(int real_index)
        {
            int ind_column = real_index % Count_str;
            return ind_column;
        }
        public int Get_Real_Index(int ind_str, int ind_col)
        {
            int index_1d = Count_str * ind_str + ind_col;
            return index_1d;
        }

        public PictureBox this[int index]
        {
            get
            {
                return Pictures[index];
            }
        }
        public PictureBox this[int ind_str, int ind_col]
        {
            get
            {
                if (ind_str < Count_str && ind_col < Count_col)
                {
                    int index = Get_Real_Index(ind_str, ind_col);
                    return Pictures[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (ind_str < Count_str && ind_col < Count_col)
                {
                    int index = Get_Real_Index(ind_str, ind_col);
                    Pictures[index] = value;
                }
            }
        }
    }
}
