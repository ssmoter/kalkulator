using System;

namespace Kalkulator
{
    class MathematicalFunctions
    {
        double w = 0;
        public string strW { get; set; }
        public string strData { get; set; }
        private bool percent = false;

        public void Percent(bool p) { percent = p; }
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

        public void setStrW(string W) { strW += W; strData += W; }
        public double getStrW() { return double.Parse(strW); }
        public void clearStrW() { strW = null; }
        public string delStrWPlus() //poprawic ujemne liczby
        {
            if (double.Parse(strW) < 0)
            {
                strW = Negate(double.Parse(strW)).ToString();
            }
            if (strW.Length > 1)
            {
                strW = strW.Remove(strW.Length - 1, 1);
            }
            else
            {
                strW = "0";
            }
            return strW;
        }

        private double fPercent(double a)
        {
            if (percent == true)
            {
                a = a / 100;
                percent = false;
            }
            return a;
        }

        public double sum(double a)
        {
           a=fPercent(a);
            return w += a;
        }
        public double difference(double a)
        {
            a = fPercent(a);
            return w -= a;
        }
        public double Multiple(double a)
        {
            a = fPercent(a);
            return w *= a;
        }
        public double Division(double a)
        {
            a = fPercent(a);
            return w /= a;
        }
        public double Sqrt(double a)
        { 
            return Math.Sqrt(a);
        }
        public double Revers(double a)
        {
            return 1 / a;
        }
        public double Square(double a)
        {
            return a * a;
        }
        public double Negate(double a)
        {
            return -a;
        }
        public void Data(string icon)
        {
            if (strData != null)
            if (strData.ToCharArray()[strData.Length-1].ToString() != icon)
            strData += icon;
        }

    }
}
