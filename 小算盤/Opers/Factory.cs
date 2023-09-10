using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 小算盤.Opers;

namespace 小算盤
{
    internal static class Factory
    {
        public static Arithmetic GetArithmetic(String calculate, int num1, int num2)
        {
            Arithmetic arithmetic = null;
            switch (calculate)
            {
                case "+":
                    arithmetic = new Plus(num1, num2);
                    break;
                case "-":
                    arithmetic = new Minus(num1, num2);
                    break;
                case "*":
                    arithmetic = new Multiply(num1, num2);
                    break;
                case "%":
                    arithmetic = new Division(num1, num2);
                    break;
            }
            return arithmetic;

        }

    }
}
