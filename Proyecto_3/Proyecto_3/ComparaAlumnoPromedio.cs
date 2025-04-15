using System;

namespace Proyecto_3
{
	/// <summary>
	/// Description of ComparaAlumnoDni.
	/// </summary>
	public class ComparaAlumnoPromedio : EstrategiaComparacionAlumno
	{
		public ComparaAlumnoPromedio()
		{
		}
		
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getPromedio()==a2.getPromedio();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getPromedio()<a2.getPromedio();

		}
		
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getPromedio()>a2.getPromedio();
						
		}
	}
}