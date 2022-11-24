using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    internal class ComplexNum
    {
        //Поле
        private double re;
        private double im;
        private double mod;
        private double arg;

        public double Re
        {
            get { return re; }
            set { re = value; }
        }
        public double Im
        {
            get { return im; }
            set { im = value; }
        }
        public double Mod
        {
            get { return mod; }
            set { mod=value; }
        }
        public double Arg
        {
            get { return arg; }
            set 
            { arg = value; }
        }
        public ComplexNum(double a, double b)// образуем комплексное число
        {
            re = a;
            im = b;
        }
        public void Add(ComplexNum num1,ComplexNum num2)
        {
            this.re = num1.re + num2.re;
            this.im = num2.im + num1.im;
        }
        public void Minus(ComplexNum num1, ComplexNum num2)
        {
            this.re = num1.re - num2.re;
            this.im = num1.im - num2.im;
        }
        public void Mult(ComplexNum num1, ComplexNum num2)
        {
            this.re = num1.re*num2.re - num1.im*num2.im;
            this.im = num1.im*num2.re + num1.re*num2.im;
        }
        public void Div(ComplexNum num1, ComplexNum num2)
        {
            if (num2.re == 0 && num2.im == 0)
                throw new ArgumentException("Делитель не может равняться нулю");
            this.re = ( num1.re*num2.re + num1.im*num2.im )/(num2.re*num2.re + num2.im*num2.im);
            this.im = (num1.im * num2.re - num1.re * num2.im) / (num2.re * num2.re + num2.im * num2.im);
        }
        public static double GetMod(ComplexNum num1)
        {
            return Math.Sqrt(num1.re*num1.re + num1.im*num1.im);
        }

        public static double GetArg(ComplexNum num1)
        {
            if (num1.re != 0)
            {
                if (num1.re > 0) return Math.Atan(num1.im / num1.re);
                if (num1.re<0 && num1.im >=0) return Math.Atan(num1.im / num1.re)+ Math.PI;
                if (num1.re<0 && num1.im<0) return Math.Atan(num1.im/num1.re) - Math.PI;
                if (num1.re == 0 && num1.im > 0) return Math.PI / 2;
                if (num1.re == 0 && num1.im < 0) return Math.PI / (-2);
            }
            throw new ArgumentException("x=0!");
        }

        //операторы
        public static ComplexNum operator+(ComplexNum num1, ComplexNum num2)
        {
            var real = num1.re+ num2.re;
            var imag = num1.im+ num2.im;
            return new ComplexNum(real,imag);
        }
        public static ComplexNum operator +(ComplexNum num1,int number)
        {
            var real = num1.re + number;
            return new ComplexNum(real, num1.im);
        }
        public static ComplexNum operator ++(ComplexNum num1)
        {
            var real = num1.re + 1;
            return new ComplexNum(real, num1.im);
        }
        public static ComplexNum operator -(ComplexNum num1, ComplexNum num2)
        {
            var real = num1.re - num2.re;
            var imag = num1.im - num2.im;
            return new ComplexNum(real, imag);
        }
        public static ComplexNum operator --(ComplexNum num1)
        {
            var real = num1.re -1;
            return new ComplexNum(real, num1.im);
        }
        public static ComplexNum operator /(ComplexNum num1, ComplexNum num2)
        {
            var real = (num1.re * num2.re + num1.im * num2.im) / (num2.re * num2.re + num2.im * num2.im);
            var imag = (num1.im * num2.re - num1.re * num2.im) / (num2.re * num2.re + num2.im * num2.im);
            return new ComplexNum(real, imag);
        }
        public static ComplexNum operator *(ComplexNum num1, ComplexNum num2)
        {
            var real = num1.re * num2.re - num1.im * num2.im;
            var imag = num1.im * num2.re + num1.re * num2.im;
            return new ComplexNum(real, imag);
        }

        public override string ToString() //Выводим результат
        {
            return $"({re},{im})";
        }
    }
}
