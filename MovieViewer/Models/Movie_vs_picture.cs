using System.ComponentModel.DataAnnotations;

namespace MovieViewer1.Models
{
    public class Movie_vs_picture
    {
        private int _sort = 0;
        [Key]
        public int mvp_id { get; set; }
        public int mvp_movie_id { get; set; }
        [StringLength(50)]
        public string mvp_pic_name { get; set; }
        [StringLength(2000)]
        public string mvp_pic_introduce { get; set; }
        public int mvp_sort { get { return _sort; } set { _sort = value; } }
    }
}