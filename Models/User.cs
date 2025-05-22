using Microsoft.AspNetCore.Identity;

namespace FlyCraiovaSE.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
    }
}
