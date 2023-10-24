using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string a = "hfjdhgfhdh";



            //    int[] vk1 = { 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0, 0};
            //    int[] vk2 = { 3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0};

            //    int b =1;//для произведения
            //    int c = 0;//для суммы
            //    int kontrol1 = 0;
            //    int kontrol2 = 0;


            //    //вычисление 1 контрольного значения
            //    for (int i = 0; i <vk1.Length;i++)
            //    {
            //        int s = Convert.ToInt32(Char.GetNumericValue(a[i]));
            //        b=s*vk1[i];
            //        c += b;

            //        if (Char.IsDigit(Convert.ToChar(a[i])))
            //        {
            //            Console.WriteLine("1");
            //        }
            //        else
            //        { Console.WriteLine("2"); }
            //    }
            //    kontrol1 = c % 11;

            //    if (kontrol1>9)
            //    {
            //        kontrol1 = kontrol1 % 10;
            //    }


            //    b = 0; c = 0;
            //    //вычисление 2 контрольного значения
            //    for (int i = 0; i < vk2.Length; i++)
            //    {
            //        int s = Convert.ToInt32(Char.GetNumericValue(a[i]));
            //        b = s * vk2[i];
            //        c += b;
            //    }
            //    kontrol2 = c % 11;

            //    if (kontrol2 > 9)
            //    {
            //        kontrol2 = kontrol2 % 10;
            //    }



            //    Console.WriteLine(a.Length);
            //}
            string innCode = "128808228380";
            if (String.IsNullOrWhiteSpace(innCode) || innCode.Length != 12)
            {
                Console.WriteLine("ytn");
            }

            int[] vk1 = { 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0, 0 };
            int[] vk2 = { 3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0 };

            int b = 1;//для произведения
            int c = 0;//для суммы
            int kontrol1 = 0;
            int kontrol2 = 0;


            //вычисление 1 контрольного значения
            for (int i = 0; i < vk1.Length; i++)
            {
                int s = Convert.ToInt32(Char.GetNumericValue(innCode[i]));
                b = s * vk1[i];
                c += b;
            }
            kontrol1 = c % 11;

            if (kontrol1 > 9)
            {
                kontrol1 = kontrol2 % 10;
            }

            b = 0; c = 0;
            //вычисление 2 контрольного значения
            for (int i = 0; i < vk2.Length; i++)
            {
                
                int s = Convert.ToInt32(Char.GetNumericValue(innCode[i]));
                b = s * vk2[i];
                c += b;
            }
            kontrol2 = c % 11;

            if (kontrol2 > 9)
            {
                kontrol2 = kontrol2 % 10;
            }

            if (innCode[10] == kontrol1 && innCode[11] == kontrol2)
            {
                Console.WriteLine("dvgfg");
            }
            else
            { Console.WriteLine("da"); }
            Console.WriteLine(innCode[10] + " " + innCode[11]);
            Console.WriteLine(kontrol1+ " " + kontrol2);
        }
    }
}
