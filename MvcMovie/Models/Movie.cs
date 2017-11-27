using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }




        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }




        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }




        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(40)]
        public string Genre { get; set; }




        [Range(1, 99)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }




        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(10)]
        public string Rating { get; set; }
    }
}