using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(5, 10);
            Complex b = new Complex(15, 20);
            Complex c;
            c = a + b;
            Complex.Print(a);
            Complex.Print(b);
            Complex.Print(c);
        }
    }

    class Complex
    {
        int _x, _y;
        public Complex() { }
        public Complex(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public static Complex operator +(Complex op1, Complex op2)
        {
            Complex result = null;
            result = new Complex();
            result._x = op1._x + op2._x;
            result._y = op1._y + op2._y;
            return result;
        }
        public static Complex operator -(Complex op1)
        {
            Complex result=null;
            result = new Complex();
            result._x-= op1._x;
            result._y-= op1._y;
            return result;
        }
        public static void Print(Complex p)
        {
            Console.WriteLine("x:{0} y:{1}", p._x, p._y);
        }
    }
}