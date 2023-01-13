using System;
using System.ComponentModel.DataAnnotations;

namespace CatalogFootballPlayers3.Models
{
    public class Footballer
    {
        public enum Gender
        {
            Man,
            Woman
        }

        public enum Countries
        {
            Russia,
            USA,
            Italy
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Gender GenderFootballer { get; set; }

        public DateTime Birthday { get; set; }

        public string TeamName { get; set; }

        public Countries Country { get; set; }
    }
}
