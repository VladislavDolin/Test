using System;

namespace Test
{
    public class Class1
    {
        public static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double TriangleArea(double FirstSide, double SecondSide, double ThirdSide)
        {
            double p = (FirstSide + FirstSide + FirstSide) / 2;

            return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
        }
    }
}
