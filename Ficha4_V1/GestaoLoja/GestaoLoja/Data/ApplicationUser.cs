using Microsoft.AspNetCore.Identity;

namespace GestaoLoja.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? Nome { get; set; }
        public string? Apelido { get; set; }
        public long? NIF { get; set; }
        public string? Rua { get; set; }
        public string? Localidade1 { get; set; }
        public string? Localidade2 { get; set; }
        public string? Pais { get; set; }
        public byte[]? Fotografia { get; set; }
    }
}
