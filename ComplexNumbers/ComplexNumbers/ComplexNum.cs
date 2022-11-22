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
        private double r;

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
            get { return r; }
            set { r=value; }
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

        public double GetMod(ComplexNum num1)
        {
            return Math.Sqrt(num1.re*num1.re + num1.im*num1.im);
        }

        public double GetArg(ComplexNum num1)
        {
            return Math.Atan(num1.im / num1.re);
        }
        public override string ToString() //Выводим результат
        {
            return $"({re},{im})";
        }
    }
}
