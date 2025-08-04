namespace SellAlleS.API.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ContraseñaHash { get; set; } = null!;
        public string Rol { get; set; } = null!;
        public int EmpresaId { get; set; }
        public int SucursalId { get; set; }
    }
}
