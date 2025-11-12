using Microsoft.AspNetCore.Identity;

namespace GestaoLoja.Data
{
    public class Inicializacao
    {
        public static async Task CriaDadosIniciais(
                UserManager<ApplicationUser> userManager,
                RoleManager<IdentityRole> roleManager)
        {
            // Adicionar default Roles
            string[] roles = ["Admin", "Gestor", "Cliente"];

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    IdentityRole roleRole = new IdentityRole(role);
                    await roleManager.CreateAsync(roleRole);
                }
            }

            // Adicionar Default User - Admin
            var defaultUser = new ApplicationUser
            {
                UserName = "admin@localhost.com",
                Email = "admin@localhost.com",
                Nome = "Administrator",
                Apelido = "Local",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id == defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user != null)
                {
                    await userManager.CreateAsync(defaultUser, "Is3c..00");
                    await userManager.AddToRoleAsync(defaultUser, "Admin");
                }
            }
        }
    }
}
