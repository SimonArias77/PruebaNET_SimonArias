using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Bookings;

    [ApiController]
    [Route("api/bookings")]
    public class BookingsController : ControllerBase
    {
        protected readonly IBookingRepository services;
        public BookingsController(IBookingRepository bookingRepository)
        {
            services = bookingRepository;
        }
    }