using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Library
{
    public struct Triangle
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public double AngleA { get; set; }
        public double AngleB { get; set; }
        public double AngleC { get; set; }

        public Triangle(int sideA, int sideB, int sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;

            double angleA;
            double angleB;
            double angleC;

            GetAngles(SideA, SideB, SideC, out angleA, out angleB, out angleC);

            this.AngleA = angleA;
            this.AngleB = angleB;
            this.AngleC = angleC;
        }

        public static void GetAngles(int SideA, int SideB, int SideC,
            out double angleA, out double angleB, out double angleC)
        {
            angleA = Math.Acos((Math.Pow(SideB, 2) + Math.Pow(SideC, 2) - Math.Pow(SideA, 2)) / (2 * SideB * SideC)) * 180 / Math.PI;
            angleB = Math.Acos((Math.Pow(SideA, 2) + Math.Pow(SideC, 2) - Math.Pow(SideB, 2)) / (2 * SideA * SideC)) * 180 / Math.PI;
            angleC = Math.Acos((Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - Math.Pow(SideC, 2)) / (2 * SideA * SideB)) * 180 / Math.PI;
        }

        public string GetInfo()
        {
            return $"Sides: {SideA}, {SideB}, {SideC} | Angles: {AngleA:F2}, {AngleB:F2}, {AngleC:F2}";
        }
    }
}
