using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportMix.Models
{
    public class Articles
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime PublishDate { get; set; } = DateTime.Now;
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
