using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular_GrahQL.Entities;
using Angular_GrahQL.Models;
using AutoMapper;

namespace Angular_GrahQL.Profiles
{
    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            DisableConstructorMapping();
            CreateMap<Guest, GuestModel>();
            CreateMap<Reservation, ReservationModel>();
            CreateMap<Room, RoomModel>();
        }
    }
}
