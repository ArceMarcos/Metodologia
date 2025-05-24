using System;

namespace Proyecto_5
{
	/// <summary>
	/// Description of ComparaAlumnoDni.
	/// </summary>
	public class ComparaAlumnoNombre : EstrategiaComparacionAlumno
	{
		public ComparaAlumnoNombre()
		{
		}
		
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getNombre().CompareTo(a2.getNombre())==0;
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getNombre().CompareTo(a2.getNombre())<0;

		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getNombre().CompareTo(a2.getNombre())>0;
						
		}
		
	}
}