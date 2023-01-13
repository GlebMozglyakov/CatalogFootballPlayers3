using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CatalogFootballPlayers3.Models
{
    public class Footballer
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }

		[DisplayName("Фамилия")]
		public string Surname { get; set; }

		[DisplayName("Пол")]
		public string Gender { get; set; }

		[DisplayName("Дата рождения")]
		public DateTime Birthday { get; set; }

		[DisplayName("Название команды")]
		public string TeamName { get; set; }

		[DisplayName("Страна")]
		public string Country { get; set; }
    }
}
