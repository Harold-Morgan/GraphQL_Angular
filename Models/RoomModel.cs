using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular_GrahQL.Entities;

namespace Angular_GrahQL.Models
{
    public class RoomModel
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

        public RoomStatus Status { get; set; }

        public bool AllowedSmoking { get; set; }
    }
}
