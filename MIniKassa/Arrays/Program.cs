using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa ölkə adı qeyd edin.");
            //    string Country = Console.ReadLine();
            //    Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa ölkəyə aid paytaxt qeyd edin.");
            //    string Capital = Console.ReadLine();

            //    dic.Add(Country, Capital);
            //}

            //while (true)
            //{

            //    Console.WriteLine("PLease select write a County name which Capital you wanna find");
            //    string selectedCountry = Console.ReadLine();
            //    foreach (var single in dic)
            //    {
            //        if (single.Key == selectedCountry)
            //        {
            //            Console.WriteLine(single.Value);
            //        }
            //        if (selectedCountry == "all")
            //        {
            //            Console.WriteLine(single.Value);
            //        }
            //        if (selectedCountry == "stop")
            //        {
            //            break;
            //        }
            //    }
            //}


            Queue<string> novbe = new Queue<string>();
            novbe.Enqueue("a");
            novbe.Enqueue("b");
            novbe.Enqueue("c");
            novbe.Enqueue("d");
            novbe.Enqueue("e");
            novbe.Enqueue("f");

           novbe.Reverse(); 


            foreach (var item in novbe)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();




        }
    }
}
