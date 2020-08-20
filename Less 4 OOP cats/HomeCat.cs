using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_4_OOP_cats
{
    class  HomeCat:SmallCats
    {
      private string Name;
       public  void EverythingDrop()
        {
            Console.WriteLine("Наташ, ты спишь ? Мы там все уронили...");            
        }

       public override void Live_bearing()
       {
            
       }
       public  void Live_bearing(out Boolean Ok )
       {
            Ok = true;
       }

        public override void Digestion()
        {


        }


        public void Digestion( Boolean ok)
        {
           

        }

       private new string MilkFeed()
       {
            return base.MilkFeed() + " конфеты";
       }

      public   HomeCat(string CATName)
        {
            Name = CATName;
        }
        ~HomeCat()
        {

        }

        private string intestines;

        public string Feed(String Food)
        {
            if (Food == "Молоко")
            {
                return " мурррррр";
                intestines = Food;
            }
            else
            {
                return "Пшшшшшш...";
            }


        }

        private uint age;

        public uint Age
        {
            set
            {
                if (value < 20)
                {
                    age = value;

                } else
                {
                    age = 0;
                }
            }
            get
            {
                return age;
            }
        }


    }
}
