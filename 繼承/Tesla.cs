using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 繼承
{
    internal class Tesla : Car // 當子類別繼承父類別，子類別會擁有父類別一切的欄位跟方法
    {
        public override void ShowCarinfo()
        {
            Console.WriteLine($"名稱:{Name}, 類型: {Type}, 容納人數: {People}");
        }
        //public void ShowCarinfo()
        //{
        //    Console.WriteLine($"名稱:{Name}, 類型: {Type}, 容納人數: {People}");
        //}
    }
}
