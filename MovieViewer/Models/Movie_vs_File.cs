using System.ComponentModel.DataAnnotations;

namespace MovieViewer.Models
{
    public class Movie_vs_File
    {
        private int _sort = 0;
        [Key]
        public int mvf_id { get; set; }
        [StringLength(200)]
        public string mvf_name { get; set; }
        [StringLength(200)]
        public string mvf_virtual_dir { get; set; }
        [StringLength(200)]
        public string mvf_save_dir { get; set; }
        [StringLength(50)]
        public string mvf_cover { get; set; }
        public int sort { get { return _sort; } set { _sort = value; } }
    }
}