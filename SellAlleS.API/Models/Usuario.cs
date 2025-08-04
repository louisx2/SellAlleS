namespace SellAlleS.API.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string ContraseñaHash { get; set; }
        public string Rol { get; set; } // Admin, Cajero, etc.
        public int EmpresaId { get; set; }
        public int SucursalId { get; set; }
    }
}// User model
