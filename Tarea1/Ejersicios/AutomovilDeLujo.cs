using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejersicios
{
	internal class AutomovilDeLujo : Automovil
	{
		private Boolean _AireAcondicionado;
		private Boolean _VentanaElectrica;
		private Boolean _AsientosPremium;
		private Boolean _PantallaTouch;

		public AutomovilDeLujo(int id, string marca, string modelo, int km, float precio) : base(id, marca, modelo, km, precio)
		{
			this._AireAcondicionado = false;
			this._VentanaElectrica = false;
			this._AsientosPremium = false;
			this._PantallaTouch = false;
		}
		public void agregarAireAcondicionado()
		{
			this._AireAcondicionado = true;
			this.precio += 10000;
		}
		public void agregarVentanaElectrica()
		{
			this._VentanaElectrica = true;
			this.precio += 20000;
		}
		public void agregaAsietosPremium()
		{
			this._AsientosPremium = true;
			this.precio += 15000;
		}
		public void agregaPantallaTouch()
		{
			this._PantallaTouch = true;
			this.precio += 20000;
		}

		public override string ToString()
		{
			string extras = "";
			if (_AireAcondicionado)
			{
				extras += "Aire Acondicionado, ";
			}
			if (_VentanaElectrica)
			{
				extras += "Ventan Electrica, ";
			}
			if (_AsientosPremium)
			{
				extras += "Asientos Premium, ";
			}
			if (_PantallaTouch)
			{
				extras += "Pantalla Touch";
			}
			extras += "\n";

			return base.ToString() + extras;
		}
	}
}
