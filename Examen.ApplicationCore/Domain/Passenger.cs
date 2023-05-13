using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public DateTime BirthDate { get; set; }

        public string TelNumber { get; set; }

        public virtual List<Traveller> Travellers { get; set; }

        public virtual List<Staff> Staffs { get; set; }

        public virtual List<Flight> Flights { get; set; }

        public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName.Equals(firstName) && LastName.Equals(lastName);
        }

        public bool CheckProfile(string firstName, string lastName, string emailAddress)
        {
            return FirstName.Equals(firstName) && LastName.Equals(lastName) && EmailAddress.Equals(emailAddress);
        }

        public bool CheckProfile(string firstName, string lastName, string emailAddress, string passportNumber)
        {
            return FirstName.Equals(firstName) && LastName.Equals(lastName) && EmailAddress.Equals(emailAddress) && PassportNumber.Equals(passportNumber);
        }



        public override string ToString()
        {
            return "Passenger{" +
                    "passportNumber='" + PassportNumber + '\'' +
                    ", firstName='" + FirstName + '\'' +
                    ", lastName='" + LastName + '\'' +
                    ", emailAddress='" + EmailAddress + '\'' +
                    ", birthDate=" + BirthDate +
                    ", telNumber='" + TelNumber + '\'' +
                    ", travellers=" + Travellers +
                    ", staffs=" + Staffs +
                    ", flights=" + Flights +
                    '}';
        }
    }
}
