public record class recProductos
{
    public int idProducto { get; set; }
    public string Description { get; set; }
    public string BarCode { get; set; }

    public recProductos(int id, string description, string barCode) {
    this.idProducto = id;
    this.Description = description;
    this.BarCode = barCode;
    }
}