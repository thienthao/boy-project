using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Boy",
                    Email = "boy@test.com",
                    UserName = "boy@test.com",
                    Address = new Address
                    {
                        FirstName = "Boy",
                        LastName = "Huynh",
                        Street = "Le Van Viet",
                        Ward = "P15",
                        District = "Q9",
                        Zipcode = "80"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}