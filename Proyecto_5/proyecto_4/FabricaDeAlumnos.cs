using System;

namespace Proyecto_5
{
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new Alumno(gen.stringAleatorio(),gen.NumeroAleatorio(10000000),gen.NumeroAleatorio(10000),(double)(gen.NumeroAleatorio(10)));
		}
		
		public override Comparable crearPorTeclado(){
			return new Alumno(lec.stringPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado());
		}
		
		
		
	}
}
