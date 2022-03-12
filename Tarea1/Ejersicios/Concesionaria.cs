using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejersicios
{
    internal class Concesionaria
    {
        private Automovil[] automovils;
        private int LIMITE;
        private int numAutos = 0;

        public Concesionaria(int limite)
        {
            this.LIMITE = limite;
            automovils = new Automovil[LIMITE];
        }


        public void agregarAutomoviles(Automovil[] automoviles)
        {
            automovils = automoviles;
        }
        public void agregarLimite(int limite)
        {
            LIMITE = limite;
        }
        public void agregarNumAuto(int numAuto)
        {
            numAuto = numAuto;
        } 

        public void AgregarAutomovil(Automovil a)
        {
            if (!lleno()&& a!=null)
            {
                automovils[numAutos] = a;
                numAutos++;
            }
            else
            {
                Console.WriteLine($"Cupo MAXIMO alcanzado {this.numAutos} o el Automovil no esxiste");

            }
        }

        public void MostrarAuto (Automovil a)
        {
            Console.WriteLine($"{a.ToString()}");
        }

        public void EliminarAuto(Automovil a)
        {
            if (!(numAutos == 0))
            {
                int posEliminada = BuscarAuto(a);
                if (posEliminada > 0)
                {
                     numAutos--;
                    for (int posicion = posEliminada; posicion+1 < LIMITE; posicion++)
                    {
                        automovils[posicion] = automovils[posicion + 1];
                    }
                }
                else
                {
                    Console.WriteLine("Ese Auto no se encuentra la Cosecioraria");
                }
               
            }
        }

        public int BuscarAuto(Automovil a)
        {
            if (!(numAutos == 0))
            {
                for (int posicion = 0; posicion <= numAutos; posicion++)
                {
                    if (automovils[posicion]==a)
                    {
                        return posicion;
                    }
                }
            }
            return -1;
        }

        public void MostrarAutos()
        {
            for (int posicion = 0; posicion < numAutos; posicion++)
            {
                MostrarAuto(automovils[posicion]);
            }
        }
        public void VaciarConcesionara()
        {
            numAutos = 0;
        }
        public Boolean lleno()
        {
            return numAutos == LIMITE;
        }
    }
}
