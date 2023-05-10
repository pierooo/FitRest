﻿using System.ComponentModel.DataAnnotations;

namespace FitRestAPI.Models
{
    public class DictionaryTable : BaseDatabase
    {
        [Required(ErrorMessage = "This should have a name!")]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
