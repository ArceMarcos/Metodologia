using System;

namespace Proyecto_5
{
	/// <summary>
	/// Description of LectorPorTeclado.
	/// </summary>
	public class LectorDeDatos
	{
		public int numeroPorTeclado(){
			Console.WriteLine("Ingrese el numero: ");
			return int.Parse(Console.ReadLine());
		}
		public string stringPorTeclado(){
			Console.WriteLine("Ingrese el string: ");
			return Console.ReadLine();
			
		}
	}
}
