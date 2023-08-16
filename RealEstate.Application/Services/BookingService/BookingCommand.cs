using RealEstate.Application.Services.RealEstateService;
using Realestate.Models;
using RealEstate.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedModelsAndValidation;
using System.Security.Cryptography.X509Certificates;

namespace RealEstate.Application.Services.BookingService
{
    public class BookingCommand : IBookingCommand
    {
        private readonly IBookingRepoService _bookingService;
        public BookingCommand(IBookingRepoService bookingRepoService)
        {
            _bookingService  = bookingRepoService;
        }


        public bool IsOverLapping(Booking booking)//Flyttes til doamin.service
        {


            throw new NotImplementedException();
        }


        public int CreateBooking(CreateBookingRequest valuesNeededForBooking )
        {
            RealEstatesE realEstateNeededForBooking = _bookingService.LoadRealEstate(valuesNeededForBooking.RealEstateId);

            Booking booking1 = new Booking()
            {
                
                RealEstate = realEstateNeededForBooking,StartTime = valuesNeededForBooking.StartTime,EndTime = valuesNeededForBooking.EndTime,

            };


            return _bookingService.CreateBooking(booking1);
        }
    }
}
