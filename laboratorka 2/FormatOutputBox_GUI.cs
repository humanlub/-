using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    interface IFormatOutputBox
    {
        bool Load_Invoking(ref RichTextBox lbox, ref PictureBox picbox);
        bool Run_Executing(int? a, int? b, ref RichTextBox lbox);
    }
    class FormatOutputBox_GUI
    {
        public enum operations
        {
            None = 0, minus, Mult,PowMinus,In, InMult
        };
        private int _sel_operation = (int)operations.None;
        private PictureBox _picturebox = null;
        private RichTextBox _rtf = null;
        private List<IFormatOutputBox> _operations = new List<IFormatOutputBox>();
        public FormatOutputBox_GUI()
        {
            foreach (operations i in Enum.GetValues(typeof(operations)))
            {
                switch (i)
                {
                    case operations.None:
                        _operations.Add(new FormatOutputBox_Handling.Operation_None());
                        break;
                    case operations.minus:
                        _operations.Add(new FormatOutputBox_Handling.Operation_Sum());
                        break;
                    case operations.Mult:
                        _operations.Add(new FormatOutputBox_Handling.Operation_Mult());
                        break;
                    case operations.PowMinus:
                        _operations.Add(new FormatOutputBox_Handling.Operation_PowMinus());
                        break;
                    case operations.In:
                        _operations.Add(new FormatOutputBox_Handling.Operation_In());
                        break;
                    case operations.InMult:
                        _operations.Add(new FormatOutputBox_Handling.Operation_InMult());
                        break;
                }
            }
        }
        public bool Invoke_Data(int sel_operation, ref PictureBox pictureBox, ref RichTextBox richTextBox)
        {
            _sel_operation = sel_operation;
            _picturebox = pictureBox;
            _rtf = richTextBox;
            Clear_Data();
            _operations[_sel_operation].Load_Invoking(ref _rtf, ref _picturebox);
            return true;
        }
        public bool Execute_Data(int? a, int? b) 
        {
            _operations[_sel_operation].Run_Executing(a, b, ref _rtf);
            return true;
        }
        public void Clear_Data() 
        {
         _rtf.Clear();
        }
    }
}
