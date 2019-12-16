using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void TestFunc()
        {
            var res = Program.MyFunction(0);
            Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void TestTaskA()
        {
            double xn = 1.25;
            double xk = 3.25;
            double dx = 0.4;
            List<double> res = Program.TaskA(xn, xk, dx);
            List<double> exp = new List<double> { 1.56271, 1.44448, 1.99658, 2.2878, 2.50881, 2.69293 };
            for (int i = 0; i < exp.Count; i++)
            {
                Assert.Equal(exp[i], res[i], 3);
            }
        }

        [Fact]
        public void TestTastA_Uncorrect()
        {
            List<double> res = Program.TaskA(3.25, 1.25, 0.7);
            Assert.Equal(new List<double>(), res);
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> xB = new List<double> { 1.84, 2.71, 3.81, 4.56, 5.62 };
            List<double> res = Program.TaskB(xB);
            List<double> exp = new List<double> { 1.77917, 2.43671, 2.91311, 3.165, 3.46686 };
            for (int i = 0; i < exp.Count; i++)
            {
                Assert.Equal(exp[i], res[i], 3);
            }
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Program.TaskB(new List<double>());
            Assert.Empty(res);
        }
    }
}
