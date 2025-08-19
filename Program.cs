using System.Collections.Generic;

namespace KlasseOpgaver
{
    internal class Program
    {                
        static void Main(string[] args)
        {
            ContextLists ctx = new();
            List<Person> allPeople = ctx.GetAllPeople();

            //List<Person> people = new(){
            //    abLi,
            //    giSk,
            //    flom,
            //    blom,
            //    alex
            //};

            Produkt egg = new(1, 2.5, "stor");
            Console.WriteLine($"{egg.Moms:N2}");

            foreach (Person person in allPeople)
            {
                person.UdskrivPerson();
            }

           

        }
    }
}

