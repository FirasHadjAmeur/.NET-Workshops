using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        
        public DateTime EmployementDate { get; set; }
        public String Function { get; set; }

        public float Salary { get; set; }

        public override string ToString()
        {
            return "Staff{" +
                     base.ToString() +
                    "employementDate=" + EmployementDate +
                    ", function='" + Function + '\'' +
                    ", salary=" + Salary +
                    '}';
        }
    }
}
