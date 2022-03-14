using System.Runtime.InteropServices;
using System.Collections.Generic;
using Examen1;

namespace Examen1
{
    class Jugador
    {
        private List<Jugada> jugadas= new List<Jugada>();
        private int Dinero=300;

        public int dinero { get => Dinero; set => Dinero = value; }

        public int apostarANumero(int apuesta,int numero)
        {
            int resultado = apuesta;
            resultado = jugar(numero)? resultado * 10 : resultado * (-1);
            return resultado;
        }
        public int apostarAColor(int apuesta,ColorJugada color){
            int resultado = apuesta;
            resultado = jugar(color)? resultado * 5 : resultado * (-1);
            return resultado;
        }
        public int apostarAEstado(int apuesta,ParImpar estado){
            int resultado = apuesta;
            resultado = jugar(estado)? resultado * 2 : resultado * (-1);
            return resultado;
        }

        public bool jugar(int apuesta)
        {
            Jugada giro = new Jugada();
            Console.WriteLine(giro);
            jugadas.Add(giro);
            return (giro.numero==apuesta);
        }
        public bool jugar(ColorJugada apuesta)
        {
            Jugada giro = new Jugada();
            Console.WriteLine(giro);
            jugadas.Add(giro);
            return (giro.color==apuesta);
        }
        public bool jugar(ParImpar apuesta)
        {
            Jugada giro = new Jugada();
            Console.WriteLine(giro);
            jugadas.Add(giro);
            return (giro.estado==apuesta);
        }
    }
}