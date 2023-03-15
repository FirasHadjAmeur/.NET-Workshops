using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {

        [Key,MaxLength(7)]
        public string PassportNumber { get; set; }
        [StringLength(25,MinimumLength =3)]
        public string FirstName { get; set; }
        public int Id { get; set; }

        public string LastName { get; set; }
        //[Column("DateOfBirth")]
        //[Display(Name = "Date Of Birth")]
        [DisplayName("Date Of Birth"),DataType(DataType.Date) ]
        public DateTime BirthDate { get; set; }
        [RegularExpression("[0-9]{8}")]
        public int? TelNumber { get; set; }
        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? EmailAddress { get; set; }

        public virtual List<Ticket> Tickets { get; set; }

        //public override string ToString()
        //{
        //    return "FirstName: " + FirstName + " LastName: " + LastName + " date of Birth: " + BirthDate;
        //}
       
        //poly par signature 
        public bool CheckProfile (string firstName , string lastName)
        {
            return FirstName==firstName && LastName==lastName;  

        }

        public bool CheckProfile(string firstName , string lastName,string email)
        {
            return FirstName == firstName && LastName == lastName && EmailAddress == email;    
        }

        public bool login(string firstName, string lastName, string email = null)
        {
           if(email != null)
            return FirstName == firstName && LastName == lastName && EmailAddress == email;
            return FirstName == firstName && LastName == lastName;
        }

        public bool login1(string firstName, string lastName, string email = null)
        {
            if (email != null)
                return CheckProfile(firstName, lastName, email);
            return FirstName == firstName && LastName == LastName;
        }

        //poly par héritage 
        public virtual void PassengerType()
        {

            Console.WriteLine("I'Passenger");
        }

    }
}
