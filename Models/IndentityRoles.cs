using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

public class Roles : IdentityRole<string>
{
    [Key]
    public int ID { get; set; }
    // public int ID { get; internal set; }
    
}

public static class SeedData
{
    public static async Task InitializeRoles(RoleManager<Roles> roleManager)
    {
        string[] roleNames = { "Admin", "Gebruiker", "Company" };

        foreach (var roleName in roleNames)
        {
            var roleExists = await roleManager.RoleExistsAsync(roleName);

            if (!roleExists)
            {
                var role = new Roles { Name = roleName };
                await roleManager.CreateAsync(role);
            }
        }
    }
}
