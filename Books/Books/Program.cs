using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksLib;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(444, "Stepiu vilkas", 12, "Ramunas", new DateTime(2020, 02, 02));
            Console.WriteLine("Priskaiciuota delspinigiu: {0}€", book1.delspiningiaiCount());
            Console.ReadLine();
        }
    }
}
