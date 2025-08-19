using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseOpgaver
{/// <summary>
/// Klasse til ansatte, der nedarver fra basen Person
/// </summary>
    public class Ansat : Person
    {
        /// <summary>
        /// field, der holder en ansats data (privat), beregnet til den ansattes grundløn
        /// </summary>
        private readonly double _løn;
        /// <summary>
        /// field, der gemmer en ansats provisionssats i procent
        /// </summary>
        private readonly double _provision;

        /// <summary>
        /// Get-property til at kunne læse værdien af løn (værdi) udefra
        /// </summary>
        public double Løn => _løn;
        /// <summary>
        /// Get-property til at kunne læse værdien af provision (provisionsprocent)
        /// </summary>
        public double Provision => _provision; //

        /// <summary>
        /// Constructor, der nedarver fra basen Person
        /// </summary>
        /// <param name="fornavn"></param>
        /// <param name="efternavn"></param>
        /// <param name="adresse"></param>
        /// <param name="tlfnr"></param>
        /// <param name="løn"></param>
        /// <param name="provision"></param>
        public Ansat(string fornavn, string efternavn, string adresse, string tlfnr, double løn, double provision)
            : base (fornavn, efternavn, adresse, tlfnr)
        {
            _løn = løn;
            _provision = provision;
        }
        /// <summary>
        /// Metode der modtager en ansats totalsalg (per dag) og returnerer provision.
        /// </summary>
        /// <param name="totalSalg"></param>
        /// <returns></returns>
        public double UdregnProvision(double totalSalg)
        {
            return totalSalg + _provision;
        }
        /// <summary>
        /// Metode til at udregne en ansats løn. Modtager provisionsprocent som double (f.eks. 0.05),
        /// lægger det sammen med den ansattes grundløn og returnerer produktet som double.
        /// </summary>
        /// <param name="provision"></param>
        /// <returns></returns>
        public double UdregnLøn(double provision) {

            return _løn + provision;
        }
    }
}

