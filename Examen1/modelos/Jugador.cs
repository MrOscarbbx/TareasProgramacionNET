using System.Runtime.InteropServices;
using System.Collections.Generic;
using Examen1;

namespace Examen1
{
    class Jugador
    {
        private List<Jugada> jugadas= new List<Jugada>();
        private int dinero=300;

        public int apostar(int apuesta, TipoApuesta tipo)
        {
            resultado = apuesta;
            switch (TipoApuesta)
            {
                case TipoApuesta.NUMERO:
                    
                    resultado = jugar()? resultado * 10 : resultado * (-1);
                    break;
                case TipoApuesta.COLOR:
                    resultado = jugar()? resultado * 5 : resultado * (-1);
                    break;
                case TipoApuesta.ESTADOS:
                    resultado = jugar()? resultado * 2 : resultado * (-1);
                    break;
                default:
                    break;
            }
            return resultado;
        }

        public bool jugar(VarEnum apuesta)
        {
            Jugada giro = new Jugada();
            return (giro.color==apuesta)||(giro.estado==apuesta)||(giro.numero==apuesta);
        }
    }
}