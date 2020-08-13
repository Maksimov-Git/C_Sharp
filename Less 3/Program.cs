using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_3
{
    

    





    class Program
    {
        public static string Conc(int a, int b)
        {
            return (a + b).ToString();
        }

        public static string Conc(int a, string b)
        {
            return a + b;
        }

        public static string Conc(string a, int b)
        {
            return a + b;
        }

        public static string Conc(string a, string b)
        {
            return a + b;
        }

        public static string Conc(object a, object b)
        {
            return a.ToString() + b.ToString();
        }

        public static string Conc( params int[] array )
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                count += array[i];
            }

            return count.ToString();
        }




        void Add(int aa, int bb, out int cc)
        {
            cc = aa + bb;

        }
        int Add(int aa, int bb)
        {
            return aa + bb;
        }
        static void Main(string[] args)
        {
            // label1:
            //     Console.WriteLine("Hell");

            //  Math.PI;

            //  goto label1;

            // int i = 0;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            //  } while (i < 5);
            // Console.ReadLine();

            int a ;
            int b ;
            int c = 0 ;
            Console.WriteLine("Введите а");
            string S = Console.ReadLine();
            if (int.TryParse(S, out a))
            {
                Console.WriteLine("Введите b");
                if (int.TryParse(Console.ReadLine(), out b))
                {
                    Add(a,b,out c);
                    c = Add(a,b);
                    Console.WriteLine(c);
                }
            } else
            {
                Console.WriteLine("вы ввели не число");
            }
            Console.ReadKey();



          

            //в "c" запишем результат, если знаем о её существовании
          void Add2(int a1,int b1)
            {
                c = a1  + b1;

            }


           






        }
    }
}
