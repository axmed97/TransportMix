using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportMix.Models;

namespace TransportMix.ViewModel
{
    public class HomeViewModel
    {
        public List<News> News { get; set; }
        public List<Articles> Articles { get; set; }
        public List<AutoSalon> AutoSalons { get; set; }
        public List<Insurance> Insurances { get; set; }
        public List<Rent> Rents { get; set; }
        public List<Transport> Transports { get; set; }
        public List<AutoService> AutoServices { get; set; }
        public List<Master> Masters { get; set; }
    }
}
