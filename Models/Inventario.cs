namespace BeautySalonManager.Models
{
    public class Inventario
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadDisponible { get; set; }
        public decimal CostoUnitario { get; set; }
        public string Proveedor { get; set; }
    }
}
