using Microsoft.AspNetCore.Identity;
using LisaKonveyer.Models;

namespace LisaKonveyer.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int? FilialId {get;set;}

        public Filial? Filial {get;set;}
    }

}
