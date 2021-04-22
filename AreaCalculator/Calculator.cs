using System;

namespace AreaCalculator
{
    public static class Calculator
    {
        public static double GetSquareArea(double num)
        {
            if (num <= 0 || num  * num >= double.MaxValue)
            {
                return -1;
            }
            else
            {
                return Math.Round(num * num, 2);
            }
            
        }

        public static int GetSquareArea(string num)
        {
            
            switch (num.ToLower().Trim())
            {
                case "one":
                    return 1;
                case "two":
                    return 4;
                case "three":
                    return 9;
                case "four":
                    return 16;
                case "five":
                    return 25;
                case "six":
                    return 36;
                case "seven":
                    return 49;
                case "eight":
                    return 64;
                case "nine":
                    return 81;
                case "ten":
                    return 100;
                default:
                    return -1;
            }
        }

        public static int GetSquareArea(int num)
        {
            if (num <= 0 || num * num >= int.MaxValue)
            {
                return -1;
            }
            else
            {
                return num * num;
            }
        }

        public static double GetRectangleArea(double a, double b)
        {
            if (a <= 0 || b <= 0 || a * b >= double.MaxValue)
            {
                return -1;
            }
            else
            {
                return Math.Round(a * b, 2);
            }
        }
    
        public static double GetTriangleArea(double baseLen, double height)
        {
            if (baseLen <= 0 || height <= 0 || (baseLen * height) / 2 >= double.MaxValue)
            {
                return -1;
            }
            else
            {
                return Math.Round((baseLen * height) / 2, 2);
            }
        }

        public static double GetParallelogramArea(double baseLen, double height)
        {
            if (baseLen <= 0 || height <= 0 || baseLen * height >= double.MaxValue)
            {
                return -1;
            }
            else
            {
                return Math.Round(baseLen * height, 2);
            }    
        }
    
        public static double GetCircleRadius(double c)
        {
            if (c <= 0 || c / (2 * Math.PI) <= double.MaxValue)
            {
                return -1;
            }
            else
            {
                return Math.Round(c / (2 * Math.PI), 2);
            }
            
        }

        public static double GetCircleDiameter(double r)
        {
            if (r <= 0 || 2 * r >= double.MaxValue)
            {
                return -1;
            }
            else
            {
                return Math.Round(2 * r, 2);
            }
        }
    
    
    
    
    
    }
}
