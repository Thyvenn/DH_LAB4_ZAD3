using System;
using Zadanie3.Zasoby;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nowy_Northwind_zad3");


            var kontekst = new Kontekst();
            kontekst.Database.EnsureCreated();

            kontekst.MyUsers.Add(new MyUsers() { Name = "Johanes", RegistrationDate = DateTime.Now});
            kontekst.SaveChanges();


        }
    }
}
