using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListClassMethodMassiveTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student tlb1 = new Student("Leyla", "Agayev");
            Student tlb2 = new Student("Nazrin", "Amirova");
            Student tlb3 = new Student("Elmar", "Memmedov");

            Console.WriteLine($"birinci telebe {tlb1.No} , ikinci ise {tlb2.No}, ucuncu ise {tlb3.No}");
            Console.ReadLine();

        }
    }

    class Student
    {
        public static int ID;
        public string Name;
        public string Surname;
        public string No;

        public Student(string ad, string Soyad)
        {
            Name = ad;
            Surname = Soyad;
            ID++;
            No = Name.Substring(0, 1) + Surname.Substring(0, 1) + ID;
        }
    }

    class Group
    {
        public string GroupName;
        public static int ID = 100;
        public int GrNmb;
        List<Student> telebelersiyagi = new List<Student>();
        public int Capacity;

        public Group(string grupadi, int MaxSay)
        {
            GroupName = grupadi;
            ID++;
            GrNmb = ID;
            Capacity = MaxSay;
        }
    }
    class Xuyas { }
}
