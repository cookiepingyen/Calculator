using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 繼承
{
    internal class Toyota : Car
    {

        public override void ShowCarinfo()
        {
            Console.WriteLine($"名稱:{Name}, 類型: {Type}, 容納人數: {People}");
        }
    }
}
