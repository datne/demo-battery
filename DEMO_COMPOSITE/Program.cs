using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPOSITE
{
    class Program
    {
        static void Main(string[] args)
        {
            IBattery b1 = new Cell(2);
            Console.WriteLine("DL max cua b1 =" + b1.getFullCapacity() + ",DL hien hanh=" + b1.ToString());
            b1.charge();
            Console.WriteLine("Dung luong cua b1 sau khi nap them 1u =" + b1.ToString());
            b1.discharge(); b1.discharge(); b1.discharge(); b1.discharge();
            Console.WriteLine("Dung luong cua b1 sau khi nap them 4u =" + b1.ToString());
            b1 = new Cell(10);
            IBattery b2 = new Battery(3, 5, false);
            IBattery b3 = new Battery(2, 10, false);
            b3.gm_add(b1); b3.gm_add(b2);
            Console.WriteLine("Trang thai cua b3 =" + b3.ToString());
            b3.discharge(); b3.discharge();
            Console.WriteLine("b3 sau khi xa 2u=" + b3.ToString());
            b3.charge(); b3.charge();
            Console.WriteLine("b3 sau khi nap 2u=" + b3.ToString());
            Console.Read();
        }
    }
}
