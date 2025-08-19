using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseOpgaver
{/// <summary>
 /// Klasse til at repræsentere et produkt med pris, vægt og størrelse.
 /// Udregner moms automatisk når pris sættes.
 /// </summary>
    internal class Produkt
    {/// <summary>
     /// privat field til at gemme pris
     /// </summary>
        private double _pris;
        /// <summary>
        /// property, der sætter prisen og udregner moms
        /// </summary>
        public double Pris //full property
        {
            get { return _pris; }
            set { _pris = PrisInformation(value); }
        }
        /// <summary>
        /// Privat felt til at gemme moms
        /// </summary>
        private double _moms;
        /// <summary>
        /// Get-property til at læse moms-værdi
        /// </summary>
        public double Moms => _moms;
        /// <summary>
        /// Vægt af produktet i kilo
        /// </summary>
        public double Kilo;
        /// <summary>
        /// Størrelse på produktet (f.eks. "stor", "lille")
        /// </summary>
        public string Størrelse;
        /// <summary>
        /// Constructor for produktet
        /// </summary>
        /// <param name="pris">Pris på produkt</param>
        /// <param name="kilo">Vægt i kilo</param>
        /// <param name="størrelse">Størrelse</param>
        public Produkt(double pris, double kilo, string størrelse)
        {
            Pris = pris;
            Kilo = kilo;
            Størrelse = størrelse;
            //Moms = UdregnMoms(Pris);
        }
        /// <summary>
        /// Udregner moms ud fra pris og returnerer prisen
        /// </summary>
        /// <param name="pris">Pris på produkt</param>
        /// <returns>Returnerer samme pris</returns>
        public double PrisInformation(double pris)
        {
            _moms = pris / 100 * 25; //sætter værdi for moms
            return pris;
        }
    }
}