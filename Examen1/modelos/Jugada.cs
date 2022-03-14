
using System;
namespace Examen1
{
    class Jugada
    {
        private ColorJugada Color;
        private ParImpar Estado;
        private int Numero;

        internal ColorJugada color { get => Color; set => Color = value; }
        internal ParImpar estado { get => Estado; set => Estado = value; }
        public int numero { get => Numero; set => Numero = value; }

        public Jugada()
        {
            var random = new Random();
            this.Numero = random.Next(37);
            this.Estado = esPar(Numero)? ParImpar.PAR : ParImpar.IMPAR;
            this.Color = queColor(Numero); 
        }
        public ColorJugada queColor(int valor)
        {
            if (valor==0)
            {
                return ColorJugada.NINGUNO;
            }
            else
            {
                return esPar(valor)? ColorJugada.NEGRO : ColorJugada.ROJO;
            }
        }
        public override string ToString()
        {
            return $"{Numero} | {Color} | {Estado}";
        }
        public bool esPar(int valor)
        {
            return valor%2 == 0;
        }
    }
}