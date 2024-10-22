using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab2_2
{
    public class MyFrac
    {
        private long nom, denom;
        public MyFrac(MyFrac newFrac)
        {
            nom = newFrac.nom;
            denom = newFrac.denom;
        }
        public MyFrac(long nom_, long denom_)
        {
            nom = nom_; denom = denom_;
            if (denom_ < 0)
            {
                nom_ = -nom_;
                denom_ = -denom_;
            }

            long gcd = GetGCD(Math.Abs(nom_), Math.Abs(denom_));

            nom = nom_ / gcd;
            denom = denom_ / gcd;
        }
        private long GetGCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public override string ToString()
        {
            return "(" + nom + "/" + denom + ")";
        }
        public string ToStringWithIntPart()
        {
            long _nom = nom; 
            long _denom = denom;
            int integerPart = 0;

            if (_nom > _denom && _nom > 0)
            {
                while (_nom > _denom)
                {
                    _nom -= _denom;
                    integerPart++;
                }
            }
            else if (_nom < -_denom && _nom < 0)
            {
                while (_nom < -_denom)
                {
                    _nom += _denom;
                    integerPart++;
                }
            }
            if (_nom < 0)
            {
                return "-" + "(" + integerPart + "+" + Math.Abs(_nom) + "/" + _denom + ")";
            }
            else
            {
                return "(" + integerPart + "+" + _nom + "/" + _denom + ")";

            }
        }
        public double DoubleValue()
        {
            return 1.0 * nom / denom;
        }
        public static MyFrac operator +(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom + f1.denom * f2.nom, f1.denom * f2.denom);
        }
        public static MyFrac operator -(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom - f1.denom * f2.nom, f1.denom * f2.denom);
        }
        public static MyFrac operator *(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.nom, f1.denom * f2.denom);
        }
        public static MyFrac operator /(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom, f1.denom * f2.nom);
        }
        public MyFrac CalcExpr1(int n)
        {
            MyFrac res = new MyFrac(0, 1);
            for (int i = 1; i <= n; i++)
            {
                MyFrac addend = new MyFrac(1, i * (i + 1));
                res = res + addend;
            }
            return res;
        }
        public MyFrac CalcExpr2(int n)
        {
            MyFrac fOne = new MyFrac(1, 1);
            MyFrac res = new MyFrac(1, 1);
            for (int i = 2; i <= n; i++)
            {
                MyFrac multiplier = new MyFrac(1, i * i);
                res = res * (fOne - multiplier);
            }
            return res;
        }
    }
}
