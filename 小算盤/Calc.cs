using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 小算盤.Opers;

namespace 小算盤
{
    internal class Calc
    {
        private String Calculate;
        private int _num1;
        private int _num2;
        public string Num1
        {
            get
            {
                return _num1.ToString();
            }
            set
            {
                _num1 = int.Parse(value);
            }
        }
        //public Plus plus;
        //public Minus minus;

        //從外面傳進來是字串, 從裡面傳出去也要是字串, 在operation裡面完成運算

        public string Num2
        {
            get
            {
                return _num2.ToString();
            }
            set
            {
                _num2 = int.Parse(value);
            }
        }

        public Calc(string num1, string num2, string calculate)
        {
            this.Calculate = calculate;
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public string math()
        {
            var arithmetic = Factory.GetArithmetic(Calculate, _num1, _num2);
            return arithmetic.Operation().ToString();
        }

        //Arithmetic arithmetic = new Plus(_num1, _num2); 這是宣告
        //arithmetic = new Plus(_num1, _num2); 這是指派
    }
}
