﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
namespace MovieProject.Models
{
    public class Movie
    {
        // primary key
        public int? MovieId { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a year")]
        [Range(1900, 2024, ErrorMessage = "Year must be between 1900 and 2024")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating")]
        [Range (1,5, ErrorMessage ="Rating must be between 1 and 5")]
        public int? Rating { get; set; }

    }
}
