using Angular_GrahQL.Entities;
using Angular_GrahQL.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Angular_GrahQL.Repositories
{
    public class ReservationRepository
    {
        private readonly MyHotelDbContext _myHotelDbContext;

        public ReservationRepository(MyHotelDbContext myHotelDbContext)
        {
            _myHotelDbContext = myHotelDbContext;
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
