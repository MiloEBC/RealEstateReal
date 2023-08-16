using RealEstate.domain.Models;
using SharedModelsAndValidation;

namespace RealEstate.Application.Services.BookingService
{
    public interface IBookingCommand
    {
        bool IsOverLapping(Booking booking);

        int  CreateBooking(CreateBookingRequest booking);

    }
}