
using System;

namespace Proyecto_7
{
	
	public class ComparaAlumnoCalificacion : EstrategiaComparacionAlumno
	{
		public ComparaAlumnoCalificacion()
		{
		}
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getCalificacion()==a2.getCalificacion();
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getCalificacion()>a2.getCalificacion();

		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getCalificacion()<a2.getCalificacion();
						
		}
	}
}
