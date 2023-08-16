using Realestate.Models;
using RealEstate.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Services.BookingService
{
    public interface IBookingRepoService
    {
        int CreateBooking(Booking booking);

        RealEstatesE LoadRealEstate(int id);


    }
}
