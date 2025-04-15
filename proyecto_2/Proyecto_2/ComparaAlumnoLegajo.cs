using System;

namespace proyecto_2
{
	/// <summary>
	/// Description of ComparaAlumnoDni.
	/// </summary>
	public class ComparaAlumnoLegajo : EstrategiaComparacionAlumno
	{
		public ComparaAlumnoLegajo()
		{
		}
		
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getLegajo()==a2.getLegajo();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getLegajo()<a2.getLegajo();

		}
		
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getLegajo()>a2.getLegajo();
						
		}
	}
}