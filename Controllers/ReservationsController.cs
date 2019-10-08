using Angular_GrahQL.Models;
using Angular_GrahQL.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_GrahQL.Controllers
{
    [Route("api/[controller]")]
    public class ReservationsController : Controller
    {
        private readonly ReservationRepository _reservationRepository;
        //private MapperConfiguration config;

        public ReservationsController( ReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
            //this.config = config;
        }

        [HttpGet("[action]")]
        public async Task<List<ReservationModel>> List()
        {
            var result = await _reservationRepository.GetAll<ReservationModel>();
            return result;
        }
    }
}
