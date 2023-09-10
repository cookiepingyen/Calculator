using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 繼承
{
    internal class Car
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int People { get; set; }

        public virtual void ShowCarinfo()
        {
            Console.WriteLine("一般車款");
        }
    }


}
