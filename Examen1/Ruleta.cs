using System.Linq;
using System.Collections.Generic;
using Examen1;
namespace Examen1
{
    class Ruleta
    {
        private Jugador jugador=new Jugador();
        private List<int> balance= new List<int>();
        private const string MENUPRICIPAL=@"
        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
        ■■■■■■■■■■■■■ VAMOS A JUGAR ■■■■■■■■■■■■■■■■
        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
        ------------¿Que quieres hacer?-------------
                        1.-Girar
                2.-Revisar Estadisticas.
                        3.-Salir.
        ";
        private const string MENUAPUESTAS=@"
        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
        ------¿De que tipo va ser la Apuesta?-------
                        1.-Por Numero
                        2.-Por Color
                     3.-Por Par o Impar.
        ";
        private const string MENUCOLOR=@"
        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
        --------------¿A Que Color?-----------------
                    1.-Por Rojo
                    2.-Por Negro
        ";
        private const string MENUESTADO=@"
        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
        --------------¿A Que Color?-----------------
                    1.-Por Par
                    2.-Por Impar
        ";
        private const string BALANCE=@"
        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
        -----------------BALANCE--------------------
        ACTIVOS                 PERDIDAS
        ";

        public void mostarMenuPrincipal(){
            int opcionSeleccionada = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(MENUPRICIPAL);
            } while (!validaMenu(3, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
                    girar();
                    break;
                case 2:
                    revisarEstadistica();
                    break;
                default:
                    break;
            }
        }

        public void girar()
        {
            if (tieneDinero(jugador))
            {
                Console.Clear();
                Console.WriteLine(MENUAPUESTAS);
                int tipo=pedirValorInt("Tipo");
                int apuesta;
                do
                {
                Console.Clear();
                Console.WriteLine($"Dinero Total : {jugador.dinero}");
                apuesta=pedirValorInt("Apuesta");
                
                if (!((jugador.dinero-apuesta)>=0)) Console.WriteLine($"Fondos Insuficientes");
                
                } 
                while (!((jugador.dinero-apuesta)>=0));
                
                int resultado;
                switch (tipo)
                {
                    case 1:
                        resultado = jugador.apostarANumero(apuesta,pedirValorInt("Numero"));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(MENUCOLOR);
                        int opcionColor=pedirValorInt("Color");
                        resultado = jugador.apostarAColor(apuesta,opcionColor==1? ColorJugada.ROJO : ColorJugada.NEGRO);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(MENUESTADO);
                        int opcionEstado=pedirValorInt("Estado");
                        resultado = jugador.apostarAEstado(apuesta,opcionEstado==1? ParImpar.PAR : ParImpar.IMPAR);
                        break;
                    default:
                        resultado=0;
                        break;
                }
                
                jugador.dinero+=resultado;
                balance.Add(resultado);
                if (resultado<0)
                {
                    Console.WriteLine($"Perdiste");
                }
                Console.WriteLine($"Dinero : {resultado}");
                Console.WriteLine($"Dinero Total : {jugador.dinero}");
                
                Console.WriteLine($"Preciona Enter para regresar al Juego");
                Console.ReadLine();
                mostarMenuPrincipal();
            }
            else
            {
                Console.WriteLine($"Ya no tienes dinero");
            }
        }
        public void revisarEstadistica()
        {
            Console.Clear();
            Console.WriteLine(BALANCE);
            int activos=0;
            int pasivos=0;
            int par=0;
            int impar=0;
            int rojos=0;
            int negros=0;
            foreach (int item in balance)
            {
                if (item>0)
                {
                    Console.WriteLine(@"        "+item);
                    activos+=item;
                }
                else
                {
                    Console.WriteLine(@"                                "+item);
                    pasivos=(item*(-1));
                }
            }
            Console.WriteLine(@$"--------------------------------------------------");
            Console.WriteLine(@$"Total   {activos}                      -{pasivos}");

            int mayor=jugador.jugadas[0].numero;
            int menor=jugador.jugadas[0].numero;
            foreach (var jugada in jugador.jugadas.GroupBy(j => j.numero))
            {
                if (jugada.Count()>mayor) mayor=jugada.Key;
                if (jugada.Count()<menor) menor=jugada.Key;
            }
            Console.WriteLine(@$"--------------------------------------------------");
            Console.WriteLine(@$"                   GIROS|{jugador.jugadas.Count()}          ");
            Console.WriteLine(@$"           MAS|{mayor}             MENOS|{menor}     ");
            foreach (var jugada in jugador.jugadas)
            {
                if (jugada.color==ColorJugada.ROJO) rojos++;
                else negros++;
                if (jugada.estado==ParImpar.PAR) par++;
                else impar++;
            }
            Console.WriteLine(@$"--------------------------------------------------");
            Console.WriteLine(@$"   PAR|{par}        IMPAR|{impar}     ROJOS|{rojos}      NEGROS|{negros}     ");
            Console.WriteLine(@$"--------------------------------------------------");
            Console.WriteLine(@$"
                Preciona Enter para regresar al Juego");
            Console.ReadLine();
            mostarMenuPrincipal();

        }

        public bool tieneDinero(Jugador jugador)
        {
            return jugador.dinero>0;
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