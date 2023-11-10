using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCodebasedTestQuestion2
{
    public class Movie
    {
        public int Mid { get; set; }
        [Required]
        public string Moviename { get; set; }
            [Display(Name = "Release Date")]
            [DataType(DataType.Date)]

        public DateTime DateOfRelease { get; set; }
        }
    }
}
