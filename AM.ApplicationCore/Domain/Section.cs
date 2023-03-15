using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Section
    {
        public int IdSection { get; set; }
        public string Name { get; set; }

        public List<Seat> Seats { get; set; }
    }
}
