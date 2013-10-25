using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
namespace PLSSequence
{
    public partial class Input : Form
    {
        public Excel.Range activityRange;
        public Excel.Range sequenceRange;
        
        public Input()
        {
            InitializeComponent();
        }
        

        private void HighlightSeq_Click(object sender, EventArgs e)
        {
            sequenceRange = GetAddress(ref SequenceAddress);            
        }
        string[] getSequences()
        {
            string [] ret = new string[sequenceRange.Rows.Count];
            for (int i = 0; i < sequenceRange.Rows.Count; i++)
            {
                ret[i] = (String)sequenceRange[i + 1, 1].Value2;
            }
            return(ret);
        }
        double[,] getActivities()
        {
            double[,] ret = new double[activityRange.Rows.Count, activityRange.Columns.Count];
            for (int i = 0; i < activityRange.Rows.Count; i++)
            {
                for (int j = 0; j < activityRange.Columns.Count; j++)
                {
                    var temp = (String)activityRange[i + 1, j + 1].Value2;
                    double value;
                    if (Double.TryParse(temp, out value))
                    {
                        ret[i, j] = value;
                        if (!checkBox2.Checked)
                            ret[i, j] = -1 * Math.Log10(ret[i, j]);                        
                    }
                    else
                    {
                        throw new InvalidSequenceException("Invalid Activity");
                    }
                }
            }
            return ret;
        }
        Microsoft.Office.Interop.Excel.Range GetAddress(ref TextBox t)
        {
            var xlApp = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
            Microsoft.Office.Interop.Excel.Range rng = null;
            try
            {
                rng = (Microsoft.Office.Interop.Excel.Range)xlApp.InputBox("Select Range", System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, 8);
            }
            catch (Exception ex)
            {
                
                return null;                
            }
            t.Text = rng.get_Address();
            return (rng);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void HighlightAct_Click(object sender, EventArgs e)
        {
            activityRange = GetAddress(ref ActivityAddress);            
        }

        private void SequenceAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActivityAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

