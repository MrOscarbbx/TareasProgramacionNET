namespace Examen1
{
    class Ruleta
    {
        private Jugador jugador=new Jugador();
        private const string MENUPRICIPAL=@"
        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
        ■■■■■■■■■■■■■ VAMOS A JUGAR ■■■■■■■■■■■■■■■■
        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
        ------------¿Que quieres hacer?-------------
                        1.-Girar
                2.-Revisar Estadisticas.
        ";

        private void mostarMenuPrincipal(){
            int opcionSeleccionada;
            do
            {
                Console.WriteLine(MENUPRICIPAL);
            } while (!validaMenu(2, ref opcionSeleccionada));
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