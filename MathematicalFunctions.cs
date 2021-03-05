using System;

namespace Kalkulator
{
    class MathematicalFunctions
    {
        double w = 0;
        public string strW { get; set; }

        public double getW() { return w; }
        public void setW()
        {
            if (strW != null)
            {
                w = double.Parse(strW);
                strW = null;
            }
        }
        public void setClearW(double W) { w = W; }

        public void setStrW(string W) { strW += W; }
        public double getStrW() { return double.Parse(strW); }
        public void clearStrW() { strW = null; }
        public string delStrW()
        {
            if (strW.Length > 1)
            {
                strW = strW.Remove(strW.Length - 1, 1);
            }
            else
            {
                strW = "0";
            }
            //w = double.Parse(strW);
            return strW;
        }

        public double sum(double a)
        { return w += a; }
        public double difference(double a)
        { return w -= a; }
        public double Multiple(double a)
        { return w *= a; }
        public double Division(double a)
        { return w /= a; }
        public double percent(double a)
        { return w *= a * 100; }
        public double Sqrt(double a)
        { return Math.Sqrt(a); }
        public double Revers(double a)
        { return 1 / a; }
        public double Square(double a)
        { return a * a; }
        public double Negate(double a)
        { return -w; }

    }
}
