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
        private const string MENUTIPOS=
        @"-----TIPO-----
        1.- Limpieza
        2.- Linea Blanca
        3.- Otro";


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
            Producto? producto = Productos.FirstOrDefault(p => p.ID == id);
            if (producto != null)
            {
                producto.nombre = pedirValorString("Nombre");
                producto.precio = pedirValorInt("Precio");
                producto.marca = pedirValorString("Marca");

                if (producto is Limpieza)
                {
                    Limpieza productoLimpieza = (Limpieza)producto;
                    productoLimpieza.cantidad = pedirValorInt("Cantidad");
                    producto=productoLimpieza;
                }

                if (producto is LineaBlanca)
                {
                    LineaBlanca productoLinea = (LineaBlanca)producto;
                    productoLinea.garantia = pedirValorString("Garantia");
                    producto=productoLinea;
                }
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
            System.Console.WriteLine(MENUTIPOS);
            int tipo=pedirValorInt("Tipo");
            foreach (Producto item in Productos)
            {
                switch (tipo)
                {
                    case 1:
                        if (item is Limpieza)
                        {
                            System.Console.WriteLine(item.ToString());
                        }
                        break;
                    case 2:
                        if (item is LineaBlanca)
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

        private void agregarProducto()
        {
            Console.Clear();
            Console.WriteLine(MENUTIPOS);
            switch (pedirValorInt("Tipo"))
            {
                case 1:
                    Limpieza? nuevaLimpieza= new Limpieza(Productos.Count() + 1,
                    pedirValorString("Nombre"),
                    pedirValorInt("Precio"),
                    pedirValorString("Marca"),
                    pedirValorInt("Cantidad")); 
                    Productos.Add(nuevaLimpieza);
                    break;
                case 2:
                    LineaBlanca? nuevaLineaBlanca= new LineaBlanca(Productos.Count() + 1,
                    pedirValorString("Nombre"),
                    pedirValorInt("Precio"),
                    pedirValorString("Marca"),
                    pedirValorString("Garantia")); 
                    Productos.Add(nuevaLineaBlanca);
                    break;
                default:
                    Producto? nuevaProducto= new Producto(Productos.Count() + 1,
                    pedirValorString("Nombre"),
                    pedirValorInt("Precio"),
                    pedirValorString("Marca")); 
                    Productos.Add(nuevaProducto);
                    break;

            }


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

        public void inicializarValores()
        {
            Producto producto= new Producto(1,"Escoba", 13,"La bruja");
            Limpieza limpieza= new Limpieza(2,"Cloro",30,"Clorex",500);
            LineaBlanca lineaBlanca= new LineaBlanca(3,"Lavadora",3000,"Yamaha","1 Año");
            Productos.Add(producto);
            Productos.Add(limpieza);
            Productos.Add(lineaBlanca);
        }
    }
}