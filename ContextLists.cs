using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseOpgaver
{
    public class ContextLists
    {
        private readonly List<Person> _allPeople;
        public IReadOnlyList<Person> AllPeople => _allPeople.AsReadOnly();

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

        public List<Person> GetAllPeople()
        {
            return new List<Person>(AllPeople); // returnerer en ny instans af AllPeople
        }
    }
}
