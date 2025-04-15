using System;

namespace proyecto_2
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
			return a1.getNombre()==a2.getNombre();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getNombre().Length>a2.getNombre().Length;

		}
		
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getNombre().Length<a2.getNombre().Length;
						
		}
	}
}