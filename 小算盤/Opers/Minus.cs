using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 小算盤.Opers;

namespace 小算盤
{
    internal class Minus : Arithmetic
    {
        public Minus(int num1, int num2) : base(num1, num2)
        {
        }

        public override int Operation()
        {
            return Num1 - Num2;
        }
    }
}
