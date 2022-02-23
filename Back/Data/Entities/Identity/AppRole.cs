using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Back.Data.Entities.Identity
{
    public class AppRole : IdentityRole<long>
    {
        public virtual ICollection<AppUserRole> UserRoles { get; set; }
    }
}