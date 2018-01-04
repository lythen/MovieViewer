using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieViewer.Models
{
    public class Movie_vs_Actor
    {
        private int _sort = 0;
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None),Column(Order =1)]
        public int mva_movie_id { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None), Column(Order = 2)]
        public int mva_actor_id { get; set; }
        [StringLength(20), Required]
        public string mva_title { get; set; }
        [StringLength(2000)]
        public string mva_introduce { get; set; }
        public int mvc_sort { get { return _sort; } set { _sort = value; } }
    }
}