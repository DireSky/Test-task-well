using System;
using System.Collections.Generic;
using System.Text;

namespace Test_task_well
{
    class Well
    {
        //p = ρgh
        public double Density { get; set; } = 10;
        public double Height { get; set; } = 1;
        private const double G = 9.81;
        internal List<double> PressForHeightMark = new List<double>();
        public void PressureCalculation(int iterations)
        {
            for (int i = 0; i < iterations; i++) PressForHeightMark.Add(Density * ((Height * i) / iterations) * G);
        }
    }
}
