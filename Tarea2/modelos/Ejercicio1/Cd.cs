

namespace Tarea2
{
    class Cd : Pelicula
    {
        public Cd(string nombre, int año, string ditector) : base(nombre, año, ditector)
        {
        }
        public Cd(int Id, string Nombre, int Año, string Director) : base(Id, Nombre, Año, Director)
        {
        }
    }
}