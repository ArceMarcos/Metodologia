
using System;

namespace Proyecto_4
{

	public class FabricaDeNumeros : FabricaDeComparables
	{
		
		public override Comparable crearAleatorio(){
			return new Numero(gen.NumeroAleatorio(10));
		}
		
		public override Comparable crearPorTeclado(){
			return new Numero(lec.numeroPorTeclado());
		}
		
		
		
		
		
		
		
	}
}
