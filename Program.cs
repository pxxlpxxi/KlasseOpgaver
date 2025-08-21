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

            Box box1 =new(3,4,5, boxType.lille);
            Box box2 =new(5,6,7,boxType.lille);
            Box box3 = new();
            box3.Højde = 8;
            box3.Bredde = 8;
            box3.Længde = 1;
            box3.Type = boxType.stor;
            Box box4 = new();
            box4.Højde = 4;
            box4.Bredde = 5;
            box4.Længde = 6;
            box4.Type = boxType.stor;
            Box box6 = new(5, 6, 7, boxType.mellem);
            Box box5 = new(5, 6, 7, boxType.mellem);

            List<Box> boxes = new List<Box>() { box1, box2, box3, box4, box5 };
            boxes.Add(box6); 
            boxes.Sort();
            boxes.ForEach(box =>
            {
            //Console.WriteLine(box.Højde.ToString(), box.Længde, box.Bredde, box.Type);
            Console.WriteLine(box.ToString());
            });

            Box box9 = box3 + box5;
            Console.WriteLine("Plusbox: " + box9.ToString());
            //boxes.ForEach(box => { Console.WriteLine(box.Højde.ToString(), box.Længde, box.Bredde, box.Type); });
            Console.WriteLine();
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

