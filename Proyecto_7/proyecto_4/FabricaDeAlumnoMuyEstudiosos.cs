using System;

namespace Proyecto_7
{
	public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new AlumnoMuyEstudioso(m.stringAleatorio(),m.NumeroAleatorio(10000000),m.NumeroAleatorio(10000),(m.NumeroAleatorio(10)));
		}
		
		public override Comparable crearPorTeclado(){
			return new AlumnoMuyEstudioso(m.stringPorTeclado(),m.numeroPorTeclado(),m.numeroPorTeclado(),m.numeroPorTeclado());
		}
		
		public override Comparable crearDesdeArchivo(){
			return new AlumnoMuyEstudioso(m.stringDesdeArchivo(10),(int)m.numeroDesdeArchivo(2),(int)m.numeroDesdeArchivo(2),(int)m.numeroDesdeArchivo(2));
		}
		
	}
}
