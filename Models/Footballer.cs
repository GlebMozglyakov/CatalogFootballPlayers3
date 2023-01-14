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
		[Required(ErrorMessage ="Поле является обязательным для заполнения")]
        public string Name { get; set; }


		[DisplayName("Фамилия")]
		[Required(ErrorMessage = "Поле является обязательным для заполнения")]
		public string Surname { get; set; }


		[DisplayName("Пол")]
		[Required(ErrorMessage = "Поле является обязательным для заполнения")]
		public string Gender { get; set; }


		[DisplayName("Дата рождения")]
		[Required(ErrorMessage = "Поле является обязательным для заполнения")]
		public DateTime Birthday { get; set; }


		[DisplayName("Название команды")]
		[Required(ErrorMessage = "Поле является обязательным для заполнения")]
		public string TeamName { get; set; }


		[DisplayName("Страна")]
		public string Country { get; set; }
    }
}
