namespace Tarea2
{
    class ControlProductos
    {
          private List<Producto> Productos;
        private const string MENUPRINCIPAL=
        @"-----Control Productos-----
        1.- Agregar Producto
        2.- Listar Productos
        3.- Eliminar Producto
        4.- Editar Producto
        5.- Salir";


        public ControlProductos()
        {
            this.Productos = new List<Producto>();
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
                    agregarProducto();
                    break;
                case 2:
                    listarProductos();
                    break;
                case 3: 
                    eliminarProducto();
                    break;
                case 4: 
                    editarProducto();
                    break;
                case 5:
                    break;
            }
        }

        private void editarProducto()
        {
            Console.Clear();
            Console.WriteLine("Editar Producto");
            listarProductos();
            int id = pedirValorInt("ID de la Producto a Editar");
            Producto? Producto = Productos.FirstOrDefault(p => p.ID == id);
            if (Producto != null)
            {
                Producto.nombre = pedirValorString("Nombre");
                Producto.precio = pedirValorInt("Precio");
                Producto.marca = pedirValorString("Marca"); 


                Console.WriteLine($@"La Producto con el ID: {id} se editó correctamente.
                 Presiona 'Enter' para continuar...");
            }
            else
            {
                Console.WriteLine($@"La Producto con el ID: {id} No Existe.
                 Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            mostrarMenuPprincipal();
        }

        private void eliminarProducto()
        {
            Console.Clear();
            listarProductos();
            int id = pedirValorInt("ID de la Producto a Eliminar");
            Producto? Producto = Productos.FirstOrDefault(p => p.ID == id);
            if (Producto != null)
            {
                Productos.Remove(Producto);
                Console.WriteLine($@"La Producto con el ID: {Producto.ID} se eliminó correctamente.
                 Presiona 'Enter' para continuar...");
            }
            else
            {
                Console.WriteLine(@"No se encontró la Producto.
                 Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            mostrarMenuPprincipal();

        }

        private void listarProductos()
        {
            Console.Clear();
            System.Console.WriteLine("Lista Productos");
            foreach (Producto item in Productos)
            {
                System.Console.WriteLine(item.ToString());
            }
        }

        private void agregarProducto()
        {
            Console.Clear();
            Producto? nuevaProducto= new Producto(Productos.Count() + 1,
            pedirValorString("Nombre"),
            pedirValorInt("Precio"),
            pedirValorString("Marca")); 
            Productos.Add(nuevaProducto);


            Console.WriteLine(@"Producto registrado correctamente.
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
    }
}