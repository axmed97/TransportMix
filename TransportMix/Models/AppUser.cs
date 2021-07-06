using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportMix.Models
{
    public class AppUser:IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
