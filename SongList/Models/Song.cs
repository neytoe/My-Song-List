using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SongList.Models
{
    public class Song
    {
        public int SongID { get; set; }

        [Required(ErrorMessage ="please enter song name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter a year")]
        [Range(1990,2021, ErrorMessage ="Year must be between 1900 and 2021")]
        public int? year { get; set; }

        [Required(ErrorMessage ="Please enter your rating")]
        [Range(1,5, ErrorMessage = "Rating must be between 1 to 5")]
        public int? Rating { get; set; }

        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "please enter genre")]
        public string GenreId { get; set; }


    }
}
