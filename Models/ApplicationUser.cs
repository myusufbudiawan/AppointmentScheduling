using Microsoft.AspNetCore.Identity;

namespace AppointmentScheduling.Models
{
    public class ApplicationUser : IdentityUser //have all the property of IdentityUser. Adding more property
    {
        public string Name { get; set; }
    }
}
