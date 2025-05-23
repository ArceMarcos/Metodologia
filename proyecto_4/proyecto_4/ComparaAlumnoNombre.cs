using System;

namespace Proyecto_4
{
	/// <summary>
	/// Description of ComparaAlumnoDni.
	/// </summary>
	public class ComparaAlumnoNombre : EstrategiaComparacionAlumno
	{
		public ComparaAlumnoNombre()
		{
		}
		
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getNombre().CompareTo(a2.getNombre())==0;
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getNombre().CompareTo(a2.getNombre())<0;

		}
		
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getNombre().CompareTo(a2.getNombre())>0;
						
		}
		
	}
}