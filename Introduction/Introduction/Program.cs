// in params if we wanna add parametrt to a methd=od as array, so by using params word, we can passs argumetn withut creating oof list
// means that we can send data and it automaticlacali will be chaned to array 
//for (int i = 0; i < studentarrayi.Length; i++)
//{
//    Console.WriteLine("Please insert Name:");
//    string name = Console.ReadLine();

//    Console.WriteLine("Insert the group ID");
//    string groupName = Console.ReadLine();

//    Console.WriteLine("PLease insert the Age");
//    int age = Convert.ToInt32(Console.ReadLine());


//    Student telebe1 = new Student(name, groupName, age);
//    studentarrayi[i] = telebe1;
//}You can't modify a collection while it's being enumerated. The second example only updates a property of the object, which is entirely different.

//            Use a for loop if you need to add / remove / modify elements in a collection:

//for (int i = 0; i < MyObjectList.Count; i++)
//            {
//                MyObjectList[i] = new MyObject();



//new sozu olanda avtomatik ctor iwe duwur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    
    internal class Program
    {
        static void Main(string[] args)

        {

            Student[] studentarrayi = new Student[4];
            for (int i = 0; i < studentarrayi.Length; i++)
            {
                Console.WriteLine("Please insert Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Insert the group ID");
                string groupName = Console.ReadLine();

                Console.WriteLine("PLease insert the Age");
                int age = Convert.ToInt32(Console.ReadLine());


                Student telebe1 = new Student(name, groupName, age);
                studentarrayi[i] = telebe1;

            }


            Console.WriteLine("select group to see the number of student in there");
            string xxx = Console.ReadLine();
            Console.WriteLine(Student.IkinciMethod(xxx, studentarrayi));


            Console.ReadLine();


        }

       

    }
    class Student
    {
        public string Name;
        public string GroupID;
        public int Age;

        public Student(string name, string groupID, int age)
        {
            Name = name;
            GroupID = groupID;
            Age = age;
        }


        public static int IkinciMethod(string input, Student[] aray)
        {
            int x = 0;

            for (int i = 0; i < aray.Length; i++)
            {
                if (input == aray[i].GroupID)
                {
                    x++;
                }

            }
            return x;
        }


    }


}








