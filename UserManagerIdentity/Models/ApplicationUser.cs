using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserManagerIdentity.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required,MaxLength(250)]
        public string FirstName { get;set; }
        [Required,MaxLength (250)]
        public string LastName { get;set; }
        public byte[] ProfilePicture { get;set;}
    }
}
