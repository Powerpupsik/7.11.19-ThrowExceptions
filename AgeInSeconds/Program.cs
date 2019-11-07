using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeInSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //VANUS SEKUNDITES
            var start = new DateTime(1988, 12, 09);
            var end = DateTime.Now;
            var age = end - start;
            Console.WriteLine(age.TotalSeconds);



            Console.ReadLine();
        }
    }
}
