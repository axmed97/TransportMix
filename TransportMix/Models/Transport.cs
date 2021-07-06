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
    public class Transport
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Phone { get; set; }
        public string SecondaryPhone { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
