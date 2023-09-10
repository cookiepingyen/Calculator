using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤.Opers
{
    // 抽象類別 => 可以宣告 已實現/未實現的 方法
    abstract class Arithmetic
    {
        public int Num1;
        public int Num2;

        public Arithmetic(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public abstract int Operation();


    }
}

