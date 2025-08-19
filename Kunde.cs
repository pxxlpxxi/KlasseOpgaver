using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseOpgaver
{
    internal class Kunde : Person
    {
        /// <summary>
        /// Private readonly fields, beskytter data
        /// </summary>
        private readonly string _email;
        private readonly int _rabatgruppe;
        private readonly double _totalIndkøb;
        /// <summary>
        /// Public properties, der læser indholdet af private fields og som kan tilgås uden for klassen
        /// </summary>
        public string Email=> _email;
        public int Rabatgruppe=> _rabatgruppe;
        public double TotalIndkøb => _totalIndkøb;
        /// <summary>
        /// Constructor til Kunde-objekt
        /// </summary>
        /// <param name="fornavn"></param>
        /// <param name="efternavn"></param>
        /// <param name="adresse"></param>
        /// <param name="tlfnr"></param>
        /// <param name="email"></param>
        /// <param name="rabatgruppe"></param>
        /// <param name="totalindkøb"></param>
        public Kunde(string fornavn, string efternavn, string adresse, string tlfnr,string email, int rabatgruppe, double totalindkøb)
            : base(fornavn, efternavn, adresse, tlfnr)
        {
            
            _email = email;
            _rabatgruppe = rabatgruppe;
            _totalIndkøb = totalindkøb;
        }
        /// <summary>
        /// Metode til at udskrive informationen om en person
        /// </summary>
        public void UdskrivPerson()
        {
            //metodekale til basen: udskriv nedarvet data (bases værdier)
            base.UdskrivPerson();
            //udskriv sub class-specifik data
            Console.WriteLine(Email);
            Console.WriteLine(Rabatgruppe);
            Console.WriteLine(TotalIndkøb);
        }
        }
    }

