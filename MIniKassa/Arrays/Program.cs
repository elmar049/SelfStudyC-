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

            //int x = 5;
            //while (6>x)
            //{

            //    Console.WriteLine("PLease select write a County name which Capital you wanna find");
            //    string selectedCountry = Console.ReadLine();
            //    foreach (var single in dic)
            //    {
            //        if (single.Key == selectedCountry)
            //        {
            //            Console.WriteLine(single.Value);
            //        }
            //        else if (selectedCountry == "all")
            //        {
            //            Console.WriteLine(single.Value);
            //        }
            //        else if (selectedCountry == "stop")
            //        {
            //            x = 10;
            //            break;
            //        }
            //    }





            //taSK2

            // Queue<string> novbe = new Queue<string>();
            // novbe.Enqueue("a");
            // novbe.Enqueue("b");
            // novbe.Enqueue("c");
            // novbe.Enqueue("d");
            // novbe.Enqueue("e");
            // novbe.Enqueue("f");

            //novbe.Reverse(); 


            // foreach (var item in novbe)
            // {
            //     Console.WriteLine(item);
            // }

            // Console.ReadLine();


            //TASK3



            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            //List<int> list2 = new List<int>();


            //for (int i = 0; i < 5; i++)
            //{

            //    list2.Add(list[5+i]);

            //}
            //for (int j = 0; j < 5; j++)
            //{
            //    list2.Add(list[j]);
            //}


            //foreach (int i in list2)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.ReadLine();





            //task4

            //SortedSet<int> xxx=new SortedSet<int>();


            // for (int i = 0; i < 7; i++)
            // {
            //     int input = int.Parse(Console.ReadLine());
            //     xxx.Add(input);
            // }
            // foreach(int input in xxx)
            // {
            //     Console.WriteLine(input);   
            // };
            // Console.ReadLine();


            //option2

            List<int> list = new List<int>() { 94, 23, 44, 75, 11, 11, 11, 11, 94 };
            List<int> list2 = new List<int>();


            for (int i = 0; i < list.Count; i++)
            {
                if (!list2.Contains(list[i]))
                {
                    list2.Add(list[i]);
                }
            }

            list2.Sort();

            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();





        }
    }
}


