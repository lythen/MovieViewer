using System;
using System.ComponentModel.DataAnnotations;

namespace MovieViewer1.Models
{
    public class Actor_Info
    {
        [Key]
        public int actor_id { get; set; }
        [StringLength(50)]
        public string actor_name_cn { get; set; }
        [StringLength(50)]
        public string acrot_name_en { get; set; }
        [StringLength(200)]
        public string actor_name_others { get; set; }
        [StringLength(2)]
        public string actor_gender { get; set; }
        public DateTime? actor_birth { get; set; }
        [StringLength(2000)]
        public string actor_introduce { get; set; }
    }
}