using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }

        public string Nationality { get; set; }

        public override string ToString()
        {
            return "Traveller{" +
                    base.ToString() +
                    "HealthInformation=" + HealthInformation +
                    ", Nationality='" + Nationality +
                    '}';
        }

    }
}
