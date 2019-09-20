using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_GrahQL.Entities
{
    public enum RoomStatus
    {
        Unavailable = 0,
        Available = 1
    }
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public RoomStatus Status { get; set; }

        public bool AllowedSmoking { get; set; }

        public Room()
        {

        }
        public Room(int number, string name, RoomStatus status, bool allowedSmoking)
        {
            Number = number;
            Name = name;
            Status = status;
            AllowedSmoking = allowedSmoking;
        }
    }
}
