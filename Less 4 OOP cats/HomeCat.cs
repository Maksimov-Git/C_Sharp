using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_4_OOP_cats
{
    class HomeCat:SmallCats
    {
        public void EverythingDrop()
        {
            Console.WriteLine("Наташ, ты спишь ? Мы там все уронили...");            
        }
        public override string MilkFeed()
        {
            return base.MilkFeed() + "конфеты";
        }

    }
}
