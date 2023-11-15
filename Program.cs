using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF_2023
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang","white",20201,100);
            Car Opel = new Car("Astra","blue",2020,120);
            Ford.fullThrottle();
            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.color);
            Ford.fullThrottle();
            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.color);
            Opel.fullThrottle();
            Console.ReadKey();



        }
    }
}
