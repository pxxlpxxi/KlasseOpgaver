using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseOpgaver
{
    /// <summary>
    /// Klasse som indeholder lister over personer (f.eks. ansatte, kunder, m.m.)
    /// </summary>
    public class ContextLists
    {
        /// <summary>
        /// Privat liste over alle personer
        /// </summary>
        private readonly List<Person> _allPeople;
        /// <summary>
        /// Public read-only liste over personer (kan ikke ændres udefra)
        /// </summary>
        public IReadOnlyList<Person> AllPeople => _allPeople.AsReadOnly();

        /// <summary>
        /// Constructor der opretter 5 personer og tilføjer dem til listen
        /// </summary>
        public ContextLists()
        {
            
            _allPeople = new List<Person>
        {
            new Person("Abraham", "Lincoln", "20953 W. Hoff Road Elwood, IL 60421, USA", "12345678"),
            new Person("Gilbert", "Skysovs", "Cloud 9, 7th Heaven, Mælkevejen", "21542121"),
            new Person("Flomme", "Fisker", "Fugleparken 36, 2860 Søborg", "27412478"),
            new Person("Blomme", "Bomsterberg", "Blommevej 5", "28412918"),
            new Person("Alexandre", "K. O.", "Alexander Platz", "294728474")
        };
        }
        /// <summary>
        /// Returnerer en kopi af listen over personer
        /// </summary>
        /// <returns>Ny liste med personer</returns>
        public List<Person> GetAllPeople()
        {
            return new List<Person>(AllPeople); // returnerer en ny instans af AllPeople
        }
    }
}
