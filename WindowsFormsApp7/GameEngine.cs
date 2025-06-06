using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public class GameEngine
    {
        private Control parentControl;

        public GameEngine(Control parent)
        {
            this.parentControl = parent;
        }

        private Panel FindPanelByName(Control parent, string panelName)
        {
            if (parent is Panel pnl && pnl.Name == panelName)
                return pnl;

            foreach (Control c in parent.Controls)
            {
                Panel result = FindPanelByName(c, panelName);
                if (result != null)
                    return result;
            }
            return null;
        }
        public int SumMatchNum(string panelName)
        {
            Panel panel = FindPanelByName(parentControl, panelName);
            if (panel == null)
            {
                MessageBox.Show("Панель " + panelName + "не найдена");
                return 0;
            }
            else
            {
                int row = 3;
                int col = 3;
                int?[,] grid = new int?[row, col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        string labelName = "Cell" + (i * col + j + i); ;
                        Label label = FindLabelInPanel(panel, labelName);
                        if (label != null && int.TryParse(label.Text, out int value))
                        {
                            grid[i, j] = value;
                        }
                        else
                        {
                            grid[i, j] = null;
                        }
                    }
                }
                int Total = 0;
                for (int i = 0; i < row; i++)//проверка каждой строки
                {
                    if (AllEqualInLine(grid, i, true))
                    {
                        Total += SumLine(grid, i, true);
                    }
                }
                return Total;
            }
        }
        private Label FindLabelInPanel(Panel parentPanel, string labelname)
        {
            foreach (Control c in parentPanel.Controls)
            {
                if (c is Label lbl && lbl.Name == labelname)
                    return lbl;
            }
            return null;
        }
        private bool AllEqualInLine(int?[,] grid, int indexOrColIndex, bool isRow)
        {
            int size = grid.GetLength(0);
            int? firstVal;
            if (isRow)
               firstVal = grid[indexOrColIndex,0];
            else 
            {
                firstVal = grid[0,indexOrColIndex];
            }
            if (!firstVal.HasValue) 
            {
                return false;
            }

            for (int i = 1; i < size; i++)
            {
                int? currentVal = isRow ? grid[indexOrColIndex, i] : grid[i, indexOrColIndex];
                if (!currentVal.HasValue || currentVal != firstVal)
                    return false;
            }

            return firstVal != 0 && firstVal.HasValue;
        }
        private int SumLine(int?[,] grid, int indexOrColIndex, bool isRow)
        {
            int sum = 0;

            for (int i = 0; i < grid.GetLength(isRow ? 1 : 0); i++)
            {
                int? val = isRow ? grid[indexOrColIndex, i] : grid[i, indexOrColIndex];
                if (val.HasValue)
                    sum += val.Value;
                
            }
            return sum;
        }


    }
}
