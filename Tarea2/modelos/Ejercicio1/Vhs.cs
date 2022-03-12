namespace Tarea2
{
    class Vhs : Pelicula
    {
        public Vhs(string nombre, int año, string ditector) : base(nombre, año, ditector)
        {
        }

        public Vhs(int Id, string Nombre, int Año, string Director) : base(Id, Nombre, Año, Director)
        {
        }
    }
}