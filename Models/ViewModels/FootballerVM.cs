using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CatalogFootballPlayers3.Models.ViewModels
{
    public class FootballerVM
    {
        public Footballer Footballer { get; set; }

        public IEnumerable<SelectListItem> FootballerSelectList { get; set; }
    }
}
