using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PLSSequence;
namespace PLSSequenceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPLS()
        {
            double [,]input  = new double[,]{
                {4,	9,	6,	7,	7,	8,	3,	2},
                {6,	15,	10,	15,	17,	22,	9,	4},
                {8,	21,	14,	23,	27,	36,	15,	6},
                {10,21,	14,	13,	11,	10,	3,	4},
                {12,27,	18,	21,	21,	24,	9,	6},
                {14,33,	22,	29,	31,	38,	15,	8},
                {16,33,	22,	19,	15, 12,	3,	6},
                {18,39,	26,	27,	25,	26,	9,	8},
                {20,45,	30,	35,	35,	40,	15,	10}
            };
            double [,] output = new double[,] {
                {1,	1},
                {3,	1},
                {5,	1},
                {1,	3},
                {3,	3},
                {5,	3},
                {1,	5},
                {3,	5},
                {5,	5},
            };
            Calculate c = new Calculate(input, output);
            double[,] w = c.getWeights();
            Assert.IsTrue(w[0, 0] == -0.045450315360345335);            
        }
        [TestMethod]
        public void TestConvertAminoAcid()
        {
            string seq = "AATG";
            double [,] ret = new double[2, 20 * 4];
            Calculate.ConvertSingle("AATG", 20, Calculate.aminoAcids, 4, ref ret, 0, seq);
            for (int i = 0; i < 20 * 4; i++)
            {
                Assert.IsTrue(ret[0, i] == 0);
            }
            Calculate.ConvertSingle("GATC", 20, Calculate.aminoAcids, 4, ref ret, 1, seq);            
            for (int i = 1; i < 20*4; i++)
            {
                if (i != 67)
                {
                    Assert.IsTrue(ret[1, i] == 0);
                }
            }
        }


    }
}
