using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less5Ex
{

    class Program
    {
        static void Main(string[] args)
        {
            Hum Vlad = new Hum(23);
            Vlad.Age = 45;
            Console.WriteLine(Vlad.Age);
            Console.WriteLine(Vlad.AgeToString());

            Console.ReadKey();


        }
    }
}
