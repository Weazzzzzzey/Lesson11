using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMSBusinesLayer;

namespace UMS
{
    public class Veiksnumas
    {
        UserRepoository UR = new UserRepoository();
        
        public void parodytiMeniu()
        {
            Console.WriteLine("1 Perziureti sarasa");
            Console.WriteLine("2 Perziureti saraso item pagal id");
            Console.WriteLine("3 Prideti nauja Useri");
            Console.WriteLine("4 Istrinti Useri");
        }

        public void perziuretiS()
        {
            foreach (var item in UR.Retrieve())
            {
                Console.WriteLine(item.UserName);
            }
        }

        public void perziuretiPagalID(int ID)
        {
            Console.WriteLine(UR.Retrieve(ID).UserName);
        }
        public void pridetiNaujaUseri(int userId, string userName, int rightsId)
        {
            Console.WriteLine("Iveskite userio ID, varda ir teise nuo 0 iki 2");
            UR.AddUser(userId,userName,rightsId);
        }
        public void istrintiUseri(int userID)
        {
            Console.WriteLine("Iveskite useri kuri norite istrinti ID");
            UR.DeleteUser(userID);
        }

    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Veiksnumas veikiantisApsas = new Veiksnumas();
            veikiantisApsas.pridetiNaujaUseri(6,"laksjdkl",2);
            veikiantisApsas.istrintiUseri(6);
            veikiantisApsas.perziuretiS();
            Console.ReadLine();
        }
    }
}
