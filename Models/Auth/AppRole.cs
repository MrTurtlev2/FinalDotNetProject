using Microsoft.AspNet.Identity.EntityFramework;

namespace FinalDotNetProject.Models.Auth
{
    public class AppRole: IdentityRole
    {
        public AppRole() : base() { }
        public AppRole(string name) : base(name) { }
    }
}
