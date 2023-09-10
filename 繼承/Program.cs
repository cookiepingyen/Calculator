using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 繼承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.ShowCarinfo();

            Car toyota = new Toyota();
            toyota.Name = "Toyota";
            toyota.Type = "汽油車";
            toyota.People = 5;
            toyota.ShowCarinfo();

            Car tesla = new Tesla(); //指派
            tesla.Name = "Tesla";
            tesla.Type = "電動車";
            tesla.People = 5;
            tesla.ShowCarinfo();

            Tesla tes = (Tesla)tesla;
            tes.ShowCarinfo();



            Console.ReadKey();




        }

        public static void showCarDetail(Car car, string type, int people)
        {
            car.Type = type;
            car.People = people;
            car.ShowCarinfo();
        }
    }

}
