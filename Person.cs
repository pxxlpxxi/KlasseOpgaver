using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KlasseOpgaver
{
    /// <summary>
    /// base class for personer, med felter til navn, adresse og telefonnummer
    /// </summary>
    public class Person
    {

        private readonly string _fornavn;
        private readonly string _efternavn;
        private readonly string _adresse;
        private readonly string _tlfnr;

        public string Fornavn => _fornavn;
        public string Efternavn => _efternavn;
        public string Adresse => _adresse;
        public string Tlfnr => _tlfnr;

        public Person(string fornavn, string efternavn, string adresse, string tlfnr)
        {
            _fornavn = fornavn;
            _efternavn = efternavn;
            _adresse = adresse;
            _tlfnr = tlfnr;
        }

        /// <summary>
        /// metode til at udskrive en al data om en person
        /// </summary>
        public void OpretPerson(string fornavn, string efternavn, string adresse, string tlf)
        {
            Person person = new(fornavn, efternavn, adresse, tlf);

            //    Console.Write("Fornavn: ");
            //    string fornavn= Console.ReadLine();
            //    Console.Write("Efternavn: ");
            //    string efternavn= Console.ReadLine();
            //    Console.Write("Adresse: ");
            //    string adresse= Console.ReadLine();
            //    Console.Write("Telefonnr: ");
            //    var cursor = Console.GetCursorPosition();

            //    int telefonnr=0;
            //    bool tlfGyldig = false;
            //    while (!tlfGyldig)
            //    {
            //        string tlf =Console.ReadLine();
            //        if (int.TryParse(tlf, out telefonnr)) {
            //            Person person = new(fornavn, efternavn, adresse, telefonnr);
            //            tlfGyldig=true;
            //        }
            //        else
            //        {
            //            string correction = new string(' ', tlf.Length);
            //            Console.SetCursorPosition(cursor.Left, cursor.Top);
            //            Console.Write(correction);
            //            Console.SetCursorPosition(cursor.Left, cursor.Top);
            //        }
            //    }
        }
        /// <summary>
        /// En metode til at udskrive alle værdier for en person
        /// </summary>
        /// <param name="person"></param>
        public void UdskrivPerson()
        {
            Console.WriteLine(Fornavn);
            Console.WriteLine(Efternavn);
            Console.WriteLine(Adresse);
            Console.WriteLine(Tlfnr);
        }
        //public List<Person> ImportPeople()
        //{

        //    People.Add(abLi); People.Add(alex); People.Add(flFi); People.Add(blBl); People.Add(giSk);

        //    return People;
        //}
    }

}