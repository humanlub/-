using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using lab2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
{

    class FormatOutputBox_Handling
    {
        public class Operation_None : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                consoleOut.AppendText("Инициализировано действие \"0\"!");
                return true;
            }

            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"0\"");
                return true;
            }
        }
        public class Operation_Sum : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                consoleOut.AppendText("Инициализировано действие \"1\"!");
                return true;
            }
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"1\":\n{0} + {1} = {2}", a, b, a + b);
                consoleOut.AppendText(str);
                return true;
            }
        }
        public class Operation_Mult : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                consoleOut.AppendText("Инициализировано действие \"2\"!");
                return true;
            }
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"2\":\n{0} * {1} = {2}", a, b, a * b);
                consoleOut.AppendText(str);
                return true;
            }
        }

        public class Operation_PowMinus : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                consoleOut.AppendText("Инициализировано действие \"3\"!");
                return true;
            }
            public bool Run_Executing(int? x, int? y, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"3\":\n{0} - {1} = {2}", x, y, Math.Pow(x.Value, 4) - Math.Pow(y.Value, 2));
                consoleOut.AppendText(str);
                return true;
            }
        }
        public class Operation_In : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                consoleOut.AppendText("Инициализировано действие \"4\"!");
                return true;
            }
            public string Collumnsub(int x, int y)
            {
                string strx = x.ToString();
                string stry = Math.Abs(y).ToString();
                int length = Math.Max(strx.Length, stry.Length);
                strx = strx.PadLeft(length);
                stry = stry.PadLeft(length);
                StringBuilder strresult = new StringBuilder();
                int borrow = 0;
                for (int i = length - 1; i >= 0; i--)
                {
                    int X = strx[i] - '0';
                    int Y = (i < length - stry.Length) ? 0 : (stry[i] - '0');
                    int Result = X + Y - borrow;
                    if (Result < 0)
                    {
                        Result += 10;
                        borrow = 1;
                    }
                    else { borrow = 0; }
                    strresult.Insert(0, Result);
                }
                return $"Результат вычитания:\n {x} \n- {Math.Abs(y)} \n{"-".PadLeft(length)}\n {strresult.ToString().TrimStart('0')}";
            }
            public bool IsValid(int? x, int? y, ref RichTextBox consoleOut)
            {
                return x.HasValue && y.HasValue && (x.Value >= 0 && x.Value < 16) && (y.Value > -12 && y.Value < 0);
            }
            public bool Run_Executing(int? x, int? y, ref RichTextBox consoleOut)
            {
                if (!IsValid(x, y, ref consoleOut))
                {
                    consoleOut.AppendText("Некорректные входные данные.\n");
                    return false;
                }

                string result = Collumnsub(x.Value, y.Value);
                consoleOut.AppendText(result + "\n");

                return true;
            }

        }
        public class Operation_InMult : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                consoleOut.AppendText("Инициализировано действие \"5\"!");
                return true;
            }
            public string ColumnMultiply(int x, int y)
            {
                StringBuilder resultBuilder = new StringBuilder();
                string strX = x.ToString();
                string strY = Math.Abs(y).ToString();
                int[] intRes = new int[strY.Length];
                for (int i = strY.Length - 1; i >= 0; i--)
                {
                    int digitY = strY[i] - '0';
                    intRes[i] = x * digitY;

                    resultBuilder.AppendLine($"{strX} * {digitY} => {intRes[i]}");
                }
                int finalResult = 0;
                for (int i = 0; i < intRes.Length; i++)
                {
                    finalResult += -intRes[i] * (int)Math.Pow(10, intRes.Length - 1 - i);
                }
                resultBuilder.AppendLine($"Результат умножения: {finalResult}");
                return resultBuilder.ToString();
            }
            public bool IsValid(int? x, int? y, ref RichTextBox consoleOut)
            {
                return x.HasValue && y.HasValue && (x.Value >= 0 && x.Value < 16) && (y.Value > -12 && y.Value < 0);
            }
            public bool Run_Executing(int? x, int? y, ref RichTextBox consoleOut)
            {
                if (!IsValid(x, y, ref consoleOut))
                {
                    consoleOut.AppendText("Некорректные входные данные.\n");
                    return false;
                }
       
                string resultMultiplication = ColumnMultiply(x.Value, y.Value);
                consoleOut.AppendText(resultMultiplication + "\n");
                return true;
            }
        }
    }
}


