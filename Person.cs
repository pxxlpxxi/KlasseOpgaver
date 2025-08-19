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
        //private fields
        private readonly string _fornavn;
        private readonly string _efternavn;
        private readonly string _adresse;
        private readonly string _tlfnr;

        // public properties
        public string Fornavn => _fornavn;
        public string Efternavn => _efternavn;
        public string Adresse => _adresse;
        public string Tlfnr => _tlfnr;

        //constructor
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
    }

}