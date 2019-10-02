using Angular_GrahQL.Entities;
using Angular_GrahQL.EntityFrameworkCore;
using Angular_GrahQL.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Angular_GrahQL.Repositories
{
    public class ReservationRepository
    {
        private readonly MyHotelDbContext _myHotelDbContext;
        private MapperConfiguration config;

        public ReservationRepository(MyHotelDbContext myHotelDbContext, MapperConfiguration config)
        {
            _myHotelDbContext = myHotelDbContext;
            this.config = config;
        }

        public async Task<List<ReservationModel>> GetAll<ReservationModel>()
        {
            return await _myHotelDbContext
                .Reservations
                .Include(x => x.Room)
                .Include(x => x.Guest)
                .ProjectTo<ReservationModel>(config)
                .ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetAll()
        {
            return await _myHotelDbContext
                .Reservations
                .Include(x => x.Room)
                .Include(x => x.Guest)
                .ToListAsync();
        }

    }
}
