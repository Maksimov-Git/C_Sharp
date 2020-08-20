using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_4_OOP_cats
{

    abstract class Mammals : vertebrates
    {
       

        public virtual void Digestion()
        {

        }
        public abstract void Live_bearing();

        public  String MilkFeed()
        {
            return "молоко";

        }
    }
}
