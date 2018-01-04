using System.ComponentModel.DataAnnotations;

namespace MovieViewer.Models
{
    public class Movie_Info
    {
        [Key]
        public int movie_id { get; set; }
        [StringLength(100),Required]
        public string movie_name { get; set; }
        [StringLength(100)]
        public string movie_sub_name { get; set; }
        [StringLength(1000)]
        public string movie_other_names { get; set; }
        [StringLength(50)]
        public string movie_cover { get; set; }
        public int movie_state { get; set; }
    }
}