using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApp.BusinessLayer.Abstract;
using RestaurantApp.DtoLayer.BookingDto;
using RestaurantApp.EntityLayer.Entities;
using System.Runtime.InteropServices.JavaScript;

namespace RestaurantAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = createBookingDto.Mail,
                Date = createBookingDto.Date,
                Name = createBookingDto.Name,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone,
            };

            _bookingService.TAdd(booking);
            return Ok("Reservation made");
        }

        [HttpDelete]
        public IActionResult DeleteBooking(int id) 
        { 
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("The reservation has been cancelled");

        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = updateBookingDto.Mail,
                BookingId=updateBookingDto.BookingId,
                Date = updateBookingDto.Date,
                Name = updateBookingDto.Name,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,
            };

            _bookingService.TUpdate(booking);
            return Ok("Reservation Update");

        }

        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id) 
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }

    }
}
