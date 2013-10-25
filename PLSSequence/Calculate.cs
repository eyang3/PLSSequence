using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Statistics.Formats;
using Accord.Statistics.Models.Regression.Linear;
using Excel = Microsoft.Office.Interop.Excel;

public class InvalidSequenceException : System.Exception
{
    public InvalidSequenceException() : base() { }
    public InvalidSequenceException(string message) : base(message) { }
    public InvalidSequenceException(string message, System.Exception inner) : base(message, inner) { }    
    protected InvalidSequenceException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) { }
}

namespace PLSSequence
{        
    public class Calculate
    {
        private PartialLeastSquaresAnalysis pls;
        public static Dictionary<char, int> aminoAcids = new Dictionary<char,int>(){
            {'A', 0}, {'V', 1}, {'L', 2}, {'I', 3}, {'M', 4}, 
            {'F', 5}, {'W', 6}, {'G', 7}, {'S', 8}, {'T', 9}, {'C', 10}, 
            {'N', 11}, {'Q', 12}, {'Y', 13}, {'D', 14}, {'E', 15}, 
            {'K', 16}, {'R', 17}, {'H', 18}, {'P', 19}};
        public static Dictionary<char, int> families= new Dictionary<char,int>(){
            {'A', 0}, {'V', 0}, {'L', 0}, {'I', 0}, 
            {'M', 0}, {'F', 0}, {'G', 1}, {'S', 1}, 
            {'T', 1}, {'C', 1}, {'N', 1}, {'Q', 1}, 
            {'Y', 1}, {'D', 2}, {'E', 2}, {'K', 3}, 
            {'R', 3}, {'H', 3},{'P', 4},{'W', 0}};
        public static String [] RevAA = new String[]{"W", "A", "V", "L", "I", "M", "F", "W", "G", "S",
                "T", "C", "N", "Q", "Y", "D", "E", "K", "R", "H", "P"};
        public static String[] RevFamily = new String[] { "Hydrophobic", "Hydrophilic", "Acidic", "Basic", "Proline" };
            
        public static double [,] ConvertToValue(String baseSequence, Excel.Range range, int selector) 
        {

            int classes = 20;
            var whichOne = aminoAcids;
            if (selector == 2)
            {
                classes = 5;
                whichOne = families;
            }
            int rows = range.Rows.Count;
            String x = (String)range.Cells[1, 1].Value2;
            int cols = x.Length;
            double [,] ret = new double[rows,cols * classes];
            for (int i = 0; i < rows; i++)
            {
                String t = range.Cells[i + 1, 1].Value2;
                ConvertSingle(baseSequence, classes, whichOne, cols, ref ret, i, t);
            }
            return (ret);
        }

        public static void ConvertSingle(String baseSequence, int classes, Dictionary<char, int> whichOne, int cols, ref double[,] ret, int i, String t)
        {
            for (int j = 0; j < cols; j++)
            {
                ret[i, j] = 0;
                if (baseSequence[j] != t[j])
                {
                    if (!whichOne.ContainsKey(t[j]))
                    {
                        throw new InvalidSequenceException("Invalid Amino Acid Found");
                    }
                    ret[i, classes * j + whichOne[t[j]]] = 1;
                }

            }
        }
        public Calculate(double [,] sequence, double [,] activity)
        {
            pls = new PartialLeastSquaresAnalysis(sequence, activity,
              AnalysisMethod.Standardize,
              PartialLeastSquaresAlgorithm.NIPALS);
        }
        public double[,] getWeights()
        {
            pls.Compute();       
            var t = pls.CreateRegression();            
            return (t.Coefficients);
        }
    }
}
