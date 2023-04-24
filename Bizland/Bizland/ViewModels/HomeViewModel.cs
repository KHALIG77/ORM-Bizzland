using System.Collections.Generic;
using Bizland.Models;

namespace Bizland.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; } 
        public List<TeamMember> Members { get; set; }   
    }
}
