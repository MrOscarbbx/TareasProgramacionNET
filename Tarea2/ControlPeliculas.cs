
using System;
namespace Tarea2 
{
    class ControlPeliculas
    {
        private List<Pelicula> peliculas;
        private const string MENUPRINCIPAL=
        @"-----Control Peliculas-----
        1.- Agregar Pelicula
        2.- Listar Peliculas
        3.- Eliminar Pelicula
        4.- Editar Pelicula
        5.- Salir";
        private const string MENUTIPOS=
        @"Tipo:
            1.-Cd
            2.-Vhs
            3.-Comun";
        public ControlPeliculas()
        {
            this.peliculas = new List<Pelicula>();
        }

        public void mostrarMenuPprincipal()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine(MENUPRINCIPAL);
            } while (!validaMenu(5, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {

                case 1:
                    agregarPelicula();
                    break;
                case 2:
                    listarPeliculas();
                    break;
                case 3: 
                    eliminarPelicula();
                    break;
                case 4: 
                    editarPelicula();
                    break;
                case 5:
                    break;
            }
        }

        private void editarPelicula()
        {
            Console.Clear();
            Console.WriteLine("Editar Pelicula");
            listarPeliculas();
            int id = pedirValorInt("ID de la Pelicula a Editar");
            Pelicula? pelicula = peliculas.FirstOrDefault(p => p.ID == id);
            if (pelicula != null)
            {
                pelicula.nombre = pedirValorString("Nombre");
                pelicula.año = pedirValorInt("Año");
                pelicula.director = pedirValorString("Director"); 


                Console.WriteLine($@"La Pelicula con el ID: {id} se editó correctamente.
                 Presiona 'Enter' para continuar...");
            }
            else
            {
                
            }
            Console.ReadLine();
            mostrarMenuPprincipal();
        }

        private void eliminarPelicula()
        {
            Console.Clear();
            listarPeliculas();
            int id = pedirValorInt("ID de la Pelicula a Editar");
            Pelicula? pelicula = peliculas.FirstOrDefault(p => p.ID == id);
            if (pelicula != null)
            {
                peliculas.Remove(pelicula);
                Console.WriteLine($@"La pelicula con el ID: {pelicula.ID} se eliminó correctamente.
                 Presiona 'Enter' para continuar...");
            }
            else
            {
                Console.WriteLine(@"No se encontró la Pelicula.
                 Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            mostrarMenuPprincipal();

        }

        private void listarPeliculas()
        {
            Console.Clear();
            System.Console.WriteLine(MENUTIPOS);
            int tipo = pedirValorInt("Tipo:");
            System.Console.WriteLine("Lista Peliculas");
            foreach (Pelicula item in peliculas)
            {
                switch (tipo)
                {
                    case 1:
                    if (item is Cd)
                        {
                            System.Console.WriteLine(item.ToString());
                        }
                        break;
                    case 2:
                    if (item is Vhs)
                        {
                            System.Console.WriteLine(item.ToString());
                        }
                        break;
                    default:
                        System.Console.WriteLine(item.ToString());
                        break;
                }
            }
        }

        private void agregarPelicula()
        {
            Console.Clear();
            System.Console.WriteLine(MENUTIPOS);
            switch (pedirValorInt("Tipo"))
            {
                case 1:
                    Console.Clear();
                    Cd? nuevoCd= new Cd(peliculas.Count() + 1,
                    pedirValorString("Nombre"),
                    pedirValorInt("Año"),
                    pedirValorString("Director")); 
                    peliculas.Add(nuevoCd); 
                    break;
                case 2:
                    Console.Clear();
                    Vhs? nuevaVhs= new Vhs(peliculas.Count() + 1,
                    pedirValorString("Nombre"),
                    pedirValorInt("Año"),
                    pedirValorString("Director")); 
                    peliculas.Add(nuevaVhs);
                    break;    
                default:
                    Console.Clear();
                    Pelicula? nuevaPelicula= new Pelicula(peliculas.Count() + 1,
                    pedirValorString("Nombre"),
                    pedirValorInt("Año"),
                    pedirValorString("Director")); 
                    peliculas.Add(nuevaPelicula);
                    break;
            }
        
            Console.WriteLine(@"Pelicula registrado correctamente.
            Presiona 'Enter' para continuar...");
            Console.ReadLine();
            mostrarMenuPprincipal();
        }

        private bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opción Invalida.");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es válido, debes ingresar un número.");
                return false;
            }
        }

        private int pedirValorInt(string texto)
        {
            int valor;
            Console.Write($"{texto}: ");
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Valor inválido. Debes ingresar un número.");
                Console.Write($"{texto}: ");
            }
            return valor;
        }

        private string pedirValorString(string texto)
        {
            string? valor;
            do
            {
                Console.Write($"{texto}: ");
                valor = Console.ReadLine();
                if (valor == null || valor == "")
                {
                    Console.WriteLine("Valor inválido.");
                }
            } while (valor == null || valor == "");
            return valor;
        }

        public void inicializarValores(){
            Pelicula pelicula= new Pelicula(1,"Kingkong",1990,"Stipehn king");
            Cd cd1= new Cd(2,"El Aro",2000,"Fausto");
            Pelicula pelicula2= new Pelicula(3,"Gozilla",1980,"Akira toriyama");
            Pelicula pelicula3= new Pelicula(4,"Star Wars",1980,"Gorge Lucas");
            Vhs vhs4= new Vhs(5,"El Señor de los Anillos",1995,"Lasetic");
            Pelicula pelicula5= new Pelicula(6,"Star Trek",1980,"Un Fulano");
            peliculas.Add(pelicula);
            peliculas.Add(cd1);
            peliculas.Add(pelicula2);
            peliculas.Add(pelicula3);
            peliculas.Add(vhs4);
            peliculas.Add(pelicula5);
        }
    }    

}