namespace MC_Shop.Models
{
    public class ArticuloModel
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Precio { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string ImagenPrincipal { get; set; } = string.Empty;
        public List<string> Imagenes { get; set; } = new List<string>();
        public string DescriptionCard { get; set; } = string.Empty;
        public int Talla { get; set; }
        public int Categoria { get; set; }
    }
}
