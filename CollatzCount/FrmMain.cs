using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollatzCount
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnRunCollatz_Click(object sender, EventArgs e)
        {
            long sequenceLength = 0;
            long firstnumber = 0;
            long sequence;

            for (int i = 2; i <= 1000000; i++)
            {
                int length = 1;
                sequence = i;
                while (sequence != 1)
                {
                    if (sequence % 2 == 0)
                    {
                        sequence = sequence / 2;
                    }
                    else
                    {
                        sequence = sequence * 3 + 1;
                    }
                    length++;
                }
                if (length > sequenceLength)
                {
                    sequenceLength = length;
                    firstnumber = i;
                }
            }

            lblSequencia.Text += " " + sequenceLength.ToString() + "  ";
            lblList.Text += firstnumber.ToString();
            lblSequencia.Visible = true;
            lblList.Visible = true;
        }

        private int size = 15;
        private int[,] array = { {75, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                       { 95, 64, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                       { 17, 47, 82, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                       { 18, 35, 87, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                       { 20, 04, 82, 47, 65, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                       { 19, 01, 23, 75, 03, 34, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                       { 88, 02, 77, 73, 07, 63, 67, 0, 0, 0, 0, 0, 0, 0, 0},
                       { 99, 65, 04, 28, 06, 16, 70, 92, 0, 0, 0, 0, 0, 0, 0},
                       { 41, 41, 26, 56, 83, 40, 80, 70, 33, 0, 0, 0, 0, 0, 0},
                       { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29, 0, 0, 0, 0, 0},
                       { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14, 0, 0, 0, 0},
                       { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57, 0, 0, 0},
                       { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48, 0, 0},
                       { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31, 0},
                       { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
        };

        private void FrmMain_Load(object sender, EventArgs e)
        {  
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[i,j]==0)
                    {
                        lblMatriz.Text += " ";
                    }
                    else
                    {
                        lblMatriz.Text += " "+ array[i, j].ToString("D2") + " ";
                    }
                }
                lblMatriz.Text += "\n";
            }
        }

        private int Recursive(int[,] array, int row, int column)
        {
            int rigth=0, left=0, center=0;
            if (row == size - 1)
                return array[row, column];
            if (column == 0)
            {
                center = Recursive(array, row + 1, column );
                rigth = Recursive(array, row + 1, column + 1);
            }
            else
            {
                left = Recursive(array, row + 1, column - 1);
                center = Recursive(array, row + 1, column);
                rigth = Recursive(array, row + 1, column + 1);
            }
            if (left >= rigth && left >= center)
            {
                return left + array[row, column];
            }
            if (center >= rigth)
            {
                return center + array[row, column];
            }
            else
            {
                return rigth + array[row, column];
            }            
        }
        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = Recursive(array, 0, 0);
            lblResultSoma.Text += Convert.ToString(count); ;
            lblResultSoma.Visible = true;

        }
    }
}
