namespace Tarea2
{
    class Limpieza : Producto
    {
        private int Cantidad;

        public Limpieza(string Nombre, int? Precio, string Marca, int Cantidad) : base(Nombre, Precio, Marca)
        {
            this.Cantidad = Cantidad;
        }

        public Limpieza(int Id, string nombre, int? precio, string marca,int Cantidad) : base(Id, nombre, precio, marca)
        {
            this.Cantidad = Cantidad;
        }

        public int cantidad { get => Cantidad; set => Cantidad = value; }

        public override string ToString() => base.ToString()+$" Cantidad: {Cantidad}";
    }
}