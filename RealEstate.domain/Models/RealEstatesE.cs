using RealEstate.domain.Models;

namespace Realestate.Models
{
    public class RealEstatesE
    {

        public int Id { get; set; }

        public string Adresse { get; set; } = string.Empty;

        public string PostNr { get; set; } = string.Empty;

        public List<Booking> bookings { get; set; }


    }
}
