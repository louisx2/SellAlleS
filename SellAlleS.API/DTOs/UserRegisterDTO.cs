namespace SellAlleS.API.DTOs
{
    public class UserRegisterDTO
    {
        public string Nombre { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public string Rol { get; set; } = null!;
        public int EmpresaId { get; set; }
        public int SucursalId { get; set; }
    }
}
