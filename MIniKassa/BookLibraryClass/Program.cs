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

            Library kitab1 = new Library("Elmar", "Ernest Heminquen", 45);
            Library kitab2 = new Library("Nazrin", "Lev Tolstoy", 69);
            Library kitab3 = new Library("Elmar", "Aleksand Pushkin", 32);
            Library kitab4 = new Library("Leyla", "Serqey Yesenin", 24);

            foreach (var item in Library.books)
            {
                string kod = item.BookCode;
                Console.WriteLine(kod);
            }


            //foreach (var item in Library.FindAllBooksByName("Leyla"))
            //{
            //    //Console.WriteLine($"Kitabin Muellifi {item.AuthorName} ve sirf o kitabin vereq sayi ise {item.Pages}, amma kodu ise {item.BookCode}");
            //}


            //foreach (var item in Library.RemoveAllBooksByName("Leyla"))
            //{
            //    //Console.WriteLine($" Yerde qalan Kitabin adi {item.Name} Kitabin Muellifi {item.AuthorName} ve sirf o kitabin vereq sayi ise {item.Pages}, amma kodu ise {item.BookCode}");
            //}


            //foreach (var item in Library.FindAllBooksByPageRangeCount(55, 69))
            //{
            //    //Console.WriteLine($" Yerde qalan Kitabin adi {item.Name} Kitabin Muellifi {item.AuthorName} ve sirf o kitabin vereq sayi ise {item.Pages}, amma kodu ise {item.BookCode}");
            //}

            foreach (var item in Library.RemoveByNO("Elm1"))
            {
                Console.WriteLine($" Yerde qalan Kitabin adi {item.Name} Kitabin Muellifi {item.AuthorName} ve sirf o kitabin vereq sayi ise {item.Pages}, amma kodu ise {item.BookCode} ");
            }


            Console.ReadLine();
        }
    }
    class Book
    {
        public static int Id;
        public string BookCode;
        public string Name;
        public string AuthorName;
        public int Pages;

    }

    class Library
    {

        public static List<Book> books = new List<Book>();


        public Library(string kitabinadinyarat, string Yazici, int say)
        {
            Book kitab = new Book();
            kitab.Name = kitabinadinyarat;
            kitab.Pages = say;
            kitab.AuthorName = Yazici;
            Book.Id++;
            kitab.BookCode = kitabinadinyarat.Substring(0, 3) + Book.Id;
            books.Add(kitab);
        }


        public static List<Book> FindAllBooksByName(string namee)
        {
            List<Book> updatedbookslist = new List<Book>();

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Name == namee)
                {
                    updatedbookslist.Add(books[i]);
                }
            }

            return updatedbookslist;
        }


        public static List<Book> RemoveAllBooksByName(string namee)
        {
            List<Book> updatedbookslist = new List<Book>();

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Name == namee)
                {
                    updatedbookslist = books;
                    updatedbookslist.Remove(books[i]);
                }
            }

            return updatedbookslist;
        }


        public static List<Book> FindAllBooksByPageRangeCount(int firstpage, int lastpage)
        {
            List<Book> updatedbookslist = new List<Book>();

            for (int i = 0; i < books.Count; i++)
            {
                if (firstpage <= books[i].Pages && books[i].Pages <= lastpage)
                {
                    updatedbookslist.Add(books[i]);
                }
            }

            return updatedbookslist;
        }

        public static List<Book> RemoveByNO(string namee)
        {
            List<Book> updatedbookslist = new List<Book>();

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].BookCode == namee)
                {
                    updatedbookslist = books;
                    books.Remove(books[i]);
                }
            }


            return updatedbookslist;
        }

    }

}
