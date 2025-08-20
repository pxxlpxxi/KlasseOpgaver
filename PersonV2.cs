using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseOpgaver
{
    /*                  Opgave med brug af Constructor og static                             */
    public class PersonV2
    {
        //statisk tæller: alle klasser deler denne. initialiseres med default-værdi 0
        private static int _tæller;

        // privat readonly field til id
        private readonly int _id;

        //properties, getters+setters
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Adresse { get; set; }
        public string Postnr { get; set; }
        public string By { get; set; }

        /// <summary>
        /// public property så id kan læses udefra
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// statisk property til at holde på antallet af id'er
        /// </summary>
        public static int Tæller => _tæller;

        /// <summary>
        /// constructor: hver gang der oprettes en ny person,
        /// tildeles et og tæller øges med 1
        /// </summary>
        public PersonV2(string fornavn, string efternavn, string adresse, string postnr, string by)
        {
            //id er én mere end tællers nuværende værdi, derefter stiger tæller med 1 (ingen har id 0)
            _id = ++_tæller; 

            Fornavn = fornavn;
            Efternavn = efternavn;
            Adresse = adresse;
            Postnr = postnr;
            By = by;
        }

        /// <summary>
        /// Instansmetode der udskriver persons data, kaldes fra instans af objektet: 
        /// personinstans.metode();
        /// </summary>
        public void skrivPersonInstans()
        {
            string navn = $"Navn: {Fornavn} {Efternavn}";
            string bar = new string('-', navn.Length + 2);

            Console.WriteLine();
            Console.WriteLine(bar +
                $"\nID: {Id}\n" +
                $"{navn}\n" +
                $"Adresse: {Adresse}\n" +
                $"{Postnr} {By}");
        }

        /// <summary>
        /// Statisk metode der udskriver en persons id og navn og det totale antal instanser, kaldes på klassen:
        /// klasse.metode(personinstans);
        /// </summary>
        public static void skrivInstans(PersonV2 person)
        {
            string navn = $"Navn: {person.Fornavn} {person.Efternavn}";
            string bar = new string('-', navn.Length + 2);
            Console.WriteLine();
            Console.WriteLine(bar +
                $"\nID: {person.Id}\n" +
                navn);

            Console.WriteLine($"Totalt antal instanser (personer): {Tæller}");
        }
    }
}

    

