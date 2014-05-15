using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using PLSSequence;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
namespace PLSSequence
{
    public partial class Ribbon1
    {
	//Testing to see whether github works
        double [] red = new double[]{237, 28, 36};
        double [] green= new double[] {34, 177, 76};

        int[] getColor(double val, double max, double[] color)
        {
            if(val < max * .2) return new int[]{255,255,255};
            int[] ret = new int[3];
            for (int i = 0; i < 3; i++)
            {
                ret[i] = (int)(color[i] + (max - val) / max * (255 - color[i]));
            }
            return (ret);

        }
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }
        private double[,] extractValues(Microsoft.Office.Interop.Excel.Range range, bool toLog)
        {
            double[,] ret = new double[range.Rows.Count, range.Columns.Count];
            for (int i = 0; i < range.Rows.Count; i++)
            {
                for (int j = 0; j < range.Columns.Count; j++)
                {
                    try
                    {                        
                        ret[i,j] = range[i + 1, j + 1].Value2;
                        if (toLog) ret[i, j] = -1 * Math.Log10(ret[i, j]);
                    }
                    catch (Exception e)
                    {
                       throw new Exception("Invalid Input");
                    }                    
                }
            }
            return (ret);
        }
        private void PaintWeights(double[,] weights, int flag)
        {
            int length = 20;
            String [] Arr = Calculate.RevAA;
            double max = weights.Cast<double>().Max();
            double min = weights.Cast<double>().Min();
            if(flag == 2) {
                length = 5;
                Arr = Calculate.RevFamily;
            }
            var xlApp = (Microsoft.Office.Interop.Excel.Application)Marshal.GetActiveObject("Excel.Application");
            var sheet = xlApp.Application.ActiveWorkbook.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);            
            int counter = 1;
            for(int i = 0;i<weights.GetLength(1); i++) 
            {
                sheet.Cells[counter++, 1] = String.Format("Activity Set {0}", i+1);
                sheet.Range[sheet.Cells[counter, 2], sheet.Cells[counter, 2 + length]].Merge();
                sheet.Cells[counter, 2] = "Amino Acids";
                sheet.Cells[counter, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                counter++;
                for (int j = 0; j < length; j++)
                {
                    sheet.Cells[counter, 2 + j] = Arr[j];
                }                
                sheet.Cells[counter++, 1] = "Position";
                for (int j = 0; j < weights.GetLength(0)/length; j++)
                {
                    sheet.Cells[counter, 1] = j + 1;
                    for (int k = 0; k < length; k++)
                    {
                        sheet.Cells[counter, k+2] = weights[j * length + k,i];
                        var t = max;
                        var c = red;
                        if(weights[j * length + k,i] < 0) {
                            t = min;
                            c = green;
                        }
                        var color = getColor(Math.Abs(weights[j * length + k, i]), Math.Abs(t), c);
                        sheet.Cells[counter, k + 2].Interior.Color = System.Drawing.Color.FromArgb(color[0], color[1], color[2]);

                    }
                    counter++;
                }
                counter++;
            }                        
        }
        private void runPLS_Click(object sender, RibbonControlEventArgs e)
        {
            Input form1 = new Input();
            var t = form1.ShowDialog();
            bool correct = true;
            if (t == DialogResult.OK)
            {
                if (form1.sequenceRange.Rows.Count != form1.activityRange.Rows.Count)
                {
                    MessageBox.Show("Number of Sequences and Activities must match");
                    correct = false;
                }

                double[,] outputs = null;
                if(correct) {
                    try
                    {
                        bool toLog = !form1.checkBox2.Checked;                    
                        outputs = extractValues(form1.activityRange, toLog);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid Activities");

                    }
                }
                if (correct)
                {
                    var flag = 1;
                    if (form1.checkBox1.Checked)
                    {
                        flag = 2;
                    }
                    var inputs = Calculate.ConvertToValue(form1.InputSequence.Text, form1.sequenceRange,flag);
                    Calculate c = new Calculate(inputs, outputs);
                    double[,] weights = c.getWeights();
                /*    double[,] weights = new double[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { -1, 2 }, { -3, 4 }, 
                                                        { 3, 1 }, { 5, 4 }, { 8, 6 }, { 10, 2 }, { -3, 4 }
                    };*/
                    PaintWeights(weights, 2);

                }



            }            

        }
    }
}
