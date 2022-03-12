using System;
namespace Tarea2
{
    class Pelicula
    {
        private int Id;
        private string? Nombre;
        private int? Año;
        private string? Director;

        public Pelicula(string nombre, int año, string ditector)
        {
            this.Nombre = nombre;
            this.Año = año;
            this.Director = director;
        }

        public Pelicula(int Id,string Nombre, int Año, string Director)
        {
            this.Id=Id;
            this.Director = Director;
            this.Año = Año;
            this.Nombre = Nombre;
        }

        public int ID
        {
            get{return Id;}
        }

        public string? nombre { get => Nombre; set => Nombre = value; }
        public int? año { get => Año; set => Año = value; }
        public string? director { get => Director; set => Director = value; }

        public override string ToString() => $"ID:{Id}|Nombre: {Nombre}, Año: {Año}, Director{Director}";
    }
}