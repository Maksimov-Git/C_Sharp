using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_4_OOP_cats
{
   abstract class Predators:Mammals
    {
        public void MeatEat(string Meat)
        {
            if (Meat.ToLower() == "мясо")
            {
                Console.WriteLine("Спасибо");

            }
            else
            {
                Console.WriteLine("Спасибо, нет");
            }
        }
    }
}
