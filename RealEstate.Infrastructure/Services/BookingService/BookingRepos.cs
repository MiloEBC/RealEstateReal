using Realestate.Models;
using RealEstate.Application.Services.BookingService;
using RealEstate.domain.Models;

namespace RealEstate.Infrastructure.Services.BookingService
{
    public class BookingRepos : IBookingRepoService
    {
        private readonly SqlDb _sqlDb;

        public BookingRepos(SqlDb sqlDb)
        {
            _sqlDb = sqlDb;
        }
        public int CreateBooking(Booking booking)
        {
            _sqlDb.bookings.Add(booking);

            _sqlDb.SaveChanges();

            return booking.Id;


        }
        public RealEstatesE LoadRealEstate(int id)
        {
            var result = _sqlDb.realEstates.Find(id);

            return result;
        }
    }
}
