using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModelsAndValidation
{
    public class CreateBookingRequest
    {

        public int RealEstateId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }




    }
}
