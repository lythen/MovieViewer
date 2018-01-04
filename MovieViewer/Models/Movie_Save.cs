using System.ComponentModel.DataAnnotations;

namespace MovieViewer.Models
{
    public class Movie_Save
    {
        [Key]
        public int save_id { get; set; }
        [StringLength(500)]
        public string save_dir { get; set; }
        [StringLength(500)]
        public string save_virtual_dir { get; set; }
    }
}