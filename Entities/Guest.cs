using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_GrahQL.Entities
{
    public class Guest
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(400)]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Patronimic { get; set; }
        public DateTime RegisterDate { get; set; }
        public Guest()
        {

        }

        public Guest(string name, DateTime registerDate)
        {
            Name = name;
            RegisterDate = registerDate;
        }

        public Guest(string name, string surname, DateTime registerDate)
        {
            Name = name;
            Surname = surname;
            RegisterDate = registerDate;
        }

        public Guest(string name, string surname, string patronimic, DateTime registerDate)
        {
            Name = name;
            Surname = surname;
            Patronimic = patronimic;
            RegisterDate = registerDate;
        }
    }
}
