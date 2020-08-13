using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_4_OOP_cats
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeCat TestCat1 = new HomeCat();
            Console.WriteLine("от класса млекопитающие наш котик получил возможность ... млекопитать...");
            Console.WriteLine((TestCat1.MilkFeed()));
            Console.WriteLine("от класса хищьники наш котик получил возможность есть мясо");
            TestCat1.MeatEat("ГВОЗДИ");
            Console.WriteLine("от класса кошачьи, наш кот получил возможность красться и приследовать, однако он так хорошь в этом, что мы этого не замечаем");
            TestCat1.CreepUp();
            TestCat1.Chase();
            Console.WriteLine("от класса малые кошки наш кот получил возможность мурчать ");
            Console.WriteLine(TestCat1.Purr());
            Console.WriteLine("а сам наш кот может только ронять вещи.... ");
            TestCat1.EverythingDrop();
            Console.WriteLine(TestCat1.ToString());
            Console.ReadKey();
        }
    }
}
