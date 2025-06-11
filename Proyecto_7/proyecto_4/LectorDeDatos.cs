using System;

namespace Proyecto_7
{
	/// <summary>
	/// Description of LectorPorTeclado.
	/// </summary>
	public class LectorDeDatos : Manejador
	{
		public LectorDeDatos(Manejador m):base(m){
			
		}
		
		public override int numeroPorTeclado(){
			Console.WriteLine("Ingrese el numero: ");
			return int.Parse(Console.ReadLine());
		}
		public override string stringPorTeclado(){
			Console.WriteLine("Ingrese el string: ");
			return Console.ReadLine();
			
		}
	}
}