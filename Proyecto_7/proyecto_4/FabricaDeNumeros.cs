
using System;

namespace Proyecto_7
{

	public class FabricaDeNumeros : FabricaDeComparables
	{
		
		public override Comparable crearAleatorio(){
			return new Numero(m.NumeroAleatorio(10));
		}
		
		public override Comparable crearPorTeclado(){
			return new Numero(m.numeroPorTeclado());
		}
		
		public override Comparable crearDesdeArchivo(){
			return new Numero((int)m.numeroDesdeArchivo(5));
		}
		
		
		
		
		
	}
}
