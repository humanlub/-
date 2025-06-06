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
                int row = 4;
                int col = 5;
                int?[,] grid = new int?[row, col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        string labelName = "Cell" + (i * col + j * 1);
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
                for (int i = 0; i < row; i++)
                {
                    if (AllEqualInLine(grid, i, true))
                    {
                        Total += SumLine(grid, i, true);
                    }
                }
                for (int j = 0; j < col; j++)
                {
                    if (AllEqualInLine(grid, j, false))
                    {
                        Total -= SumLine(grid, j, false);
                    }
                }
                if (DiagEqual(grid, true)) 
                {
                    Total += SumDiag(grid, true);
                }
                if (DiagEqual(grid, false)) 
                {
                    Total += SumDiag(grid, true);
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
            int? firstVal = isRow ? grid[indexOrColIndex, 0] : grid[0, indexOrColIndex];

            if (!firstVal.HasValue)
                return false;

            for (int i = 1; i < grid.GetLength(isRow ? 1 : 0); i++)
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
        private bool DiagEqual(int?[,] grid, bool mainDiag) 
        {
            int size = Math.Min(grid.GetLength(0), grid.GetLength(1));
            int? firstVal = mainDiag ? grid[0, 0] : grid[0, size - 1];
            if (!firstVal.HasValue) 
            {
                return false;
            }
            for (int i = 0; i < size; i++) 
            {
                int rowId = i;
                int colId = mainDiag ? i : size - 1 - i;
                int? val = grid[rowId, colId];
                if (!val.HasValue || val != firstVal) 
                {
                    return false;
                }
                if (!val.HasValue || val == 0) 
                {
                    return false;
                }
               
            }
            return true;

        }
        private int SumDiag(int?[,] grid, bool mainDiag) 
        {
            int size = Math.Min(grid.GetLength(0), grid.GetLength(1));
            int sum = 0;
            for (int i = 0; i < size; i++) 
            {
                int rowId = i;
                int colId = mainDiag? i : size - 1 - i;
                if (grid[rowId, colId].HasValue) 
                {
                    sum += grid[rowId, colId].Value;
                }
                
            }
            return sum;
        }

    }
}
