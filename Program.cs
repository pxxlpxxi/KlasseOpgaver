using System.Collections.Generic;

namespace KlasseOpgaver
{
    internal class Program
    {
        /// <summary>
        /// Programklasse med Main-metoden, hvor programmet starter
        /// </summary>
        static void Main(string[] args)
        {
            //instansierer (laver et objekt af) klassen ContextLists
            ContextLists ctx = new();
            List<Person> allPeople = ctx.GetAllPeople();

            //opretter et peodukt og udskriver produktets moms
            Produkt egg = new(1, 2.5, "stor");
            Console.WriteLine($"{egg.Moms:N2}");

            //foreach-loop med metodekald: udskriver alle personer i listen allPeople
            foreach (Person person in allPeople)
            {
                person.UdskrivPerson();
                Console.WriteLine();
            }

           

        }
    }
}

