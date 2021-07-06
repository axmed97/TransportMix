using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportMix.Models;

namespace TransportMix.ViewModel
{
    public class UserAddRoleVM
    {
        public AppUser AppUser { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
