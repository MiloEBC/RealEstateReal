using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Application.Services.BookingService;
using RealEstate.Application.Services.RealEstateService;
using RealEstate.domain.Models;
using SharedModelsAndValidation;

namespace Realestate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private readonly IBookingCommand _bookingCommand;

        public BookingController(IBookingCommand bookingCommand) //kan få adgang til service og metoder
        {


            _bookingCommand = bookingCommand;


        }

        [HttpPost]

        public async Task<ActionResult<List<RealEstatesE>>> CreateBooking(CreateBookingRequest booking)
        {




            var result = _bookingCommand.CreateBooking(booking);


            return Ok(result);
        }



    }
}
