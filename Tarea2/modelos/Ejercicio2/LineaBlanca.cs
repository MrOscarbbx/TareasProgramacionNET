namespace Tarea2
{
    class LineaBlanca : Producto
    {
        private string? Garantia;

        public LineaBlanca(string Nombre, int? Precio, string Marca,string Garantia) : base(Nombre, Precio, Marca)
        {
            this.Garantia=Garantia;
        }

        public LineaBlanca(int Id, string nombre, int? precio, string marca, string Garantia) : base(Id, nombre, precio, marca)
        {
            this.Garantia = Garantia;
        }

        public string garantia { get => Garantia; set => Garantia = value; }

        public override string ToString() => base.ToString()+$" Garantiz: {Garantia}";

    }
}