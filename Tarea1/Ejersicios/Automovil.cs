using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejersicios
{
	internal class Automovil
	{
		private int _id;
		private string _marca;
		private string _modelo;
		private int _km;
		private float _precio;

		public Automovil(int id, string marca, string modelo, int km, float precio)
		{
			this._id = id;
			this._marca = marca;
			this._modelo = modelo;
			this._km = km;
			this._precio = precio;
		}

		public int id { set; get; }
		public string marca { set; get; }
		public string modelo { set; get; }
		public int km { set; get; }
		public float precio { set; get; }

		public override string ToString()
		{
			return $"ID:{this._id} ,Marca:{this._marca} ,Modelo:{this._modelo} ,KM:{this._km} ,Precio:{this._precio}  \n";
		}
	}
}
