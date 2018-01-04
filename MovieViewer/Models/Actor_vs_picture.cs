using System.ComponentModel.DataAnnotations;

namespace MovieViewer.Models
{
    public class Actor_vs_picture
    {
        private int _sort = 0;
        [Key]
        public int avp_id { get; set; }
        public int avp_actor_id { get; set; }
        [StringLength(50)]
        public string avp_pic_name { get; set; }
        [StringLength(1000)]
        public string avp_pic_info { get; set; }
        public int avp_pic_sort { get { return _sort; } set { _sort = value; } }
    }
}