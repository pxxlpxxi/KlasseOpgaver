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

            Box box1 =new(Størrelse.lille);
            Box box2 =new(Størrelse.lille);
            //opretter et peodukt og udskriver produktets moms
            Produkt egg = new(1, 2.5, "stor");
            Console.WriteLine($"{egg.Moms:N2}");

            //foreach-loop med metodekald: udskriver alle personer i listen allPeople
            foreach (Person person in allPeople)
            {
                person.UdskrivPerson();
                Console.WriteLine();
            }

            PersonV2 pe1 = new("FørstePersonsFornavn", "PersonsEfternavn", "PersonsAdresse", "PersonsPostnummer", "Personsby");
            PersonV2 pe2 = new("AndenPersonsFornavn", "PersonsEfternavn", "PersonsAdresse", "PersonsPostnummer", "Personsby");
            PersonV2 pe3 = new("TredjePersonsFornavn", "PersonsEfternavn", "PersonsAdresse", "PersonsPostnummer", "Personsby");

            PersonV2.skrivInstans(pe3);
            PersonV2.skrivInstans(pe2);
            PersonV2.skrivInstans(pe1);

            pe3.skrivPersonInstans();
            pe2.skrivPersonInstans();
            pe1.skrivPersonInstans();

        }
    }
}

