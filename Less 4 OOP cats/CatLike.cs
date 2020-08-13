using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_4_OOP_cats
{
  abstract  class CatLike: Predators
    {
        //крадется ...
        public void CreepUp()
        {
            Console.WriteLine("*Легкое шуршание");
        }

        //преследует
       public void Chase()
        {

        }
    }
}
