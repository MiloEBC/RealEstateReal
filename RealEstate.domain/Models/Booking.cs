
using Realestate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.domain.Models
{
    public class Booking


    {


        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        required public RealEstatesE RealEstate { get; set; } // SKAL HAVE REALESTATE


    }

}
