
using System;

namespace Proyecto_4
{
	
	public class ComparaAlumnoCalificacion : EstrategiaComparacionAlumno
	{
		public ComparaAlumnoCalificacion()
		{
		}
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getCalificacion()==a2.getCalificacion();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getCalificacion()>a2.getCalificacion();

		}
		
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getCalificacion()<a2.getCalificacion();
						
		}
	}
}
