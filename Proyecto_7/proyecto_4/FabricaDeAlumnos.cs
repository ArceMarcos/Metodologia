using System;

namespace Proyecto_7
{
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new Alumno(m.stringAleatorio(),m.NumeroAleatorio(10000000),m.NumeroAleatorio(10000),(int)(m.NumeroAleatorio(10)));
		}
		
		public override Comparable crearPorTeclado(){
			return new Alumno(m.stringPorTeclado(),m.numeroPorTeclado(),m.numeroPorTeclado(),m.numeroPorTeclado());
		}
		public override Comparable crearDesdeArchivo(){
			return new Alumno(m.stringDesdeArchivo(10),(int)m.numeroDesdeArchivo(2),(int)m.numeroDesdeArchivo(2),(int)m.numeroDesdeArchivo(2));
		}
		
		
	}
}
