using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less5Ex
{
    class Hum
    {
        public int КоличествоЗубов = 32;
        private string s_age;
        private uint age;
        public uint Age
        {
            get
            {
                if (age > 35)
                {
                    return 18;
                } else
                {
                    return age;
                }

            }

            set
            {
                if (value < 3)
                {
                    s_age = "младенчество";
                    age = value;
                }
                if (value > 35)
                {
                    s_age = "зрелость";
                    age = value;
                }

            }
        }

        public Hum(UInt32 Age  )
        {
            if(Age < 120)
            {
                age = Age;
            } else
            {
                age = 70;
            }

        }

        public string AgeToString()
        {
            switch (age)
            {
                case 1:
                case 2:
                case 3:
                    return "Младенчество";
                        break;

                default:
                    return "не младенец";
                    break;
            }

        } 

        private string gender;

        private void thinking()
        {

        }
        public string speech()
        {
            return "";
        } 


    }
}
