namespace Tarea2
{
    class Producto
    {
        private int Id;
        private string? Nombre;
        private int? Precio;
        private string? Marca;

        public Producto(int Id,string nombre, int? precio, string marca) :
         this(nombre, precio, marca)
        {
            this.Id=Id;
        }

        public Producto(string Nombre, int? Precio, string Marca)
        {
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Marca = Marca;
        }

        public string? nombre { get => Nombre; set => Nombre = value; }
        public int? precio { get => Precio; set => Precio = value; }
        public string? marca { get => Marca; set => Marca = value; }
        public int ID { get => Id; set => Id = value; }

        public override string ToString() => $"ID:{Id}| Nombre: {Nombre}, Precio: {Precio}, Marca: {Marca}";

    }
}