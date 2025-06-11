using System;

namespace Proyecto_60
{
	public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new AlumnoMuyEstudioso(gen.stringAleatorio(),gen.NumeroAleatorio(10000000),gen.NumeroAleatorio(10000),(double)(gen.NumeroAleatorio(10)));
		}
		
		public override Comparable crearPorTeclado(){
			return new AlumnoMuyEstudioso(lec.stringPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado());
		}
		
		
		
	}
}
