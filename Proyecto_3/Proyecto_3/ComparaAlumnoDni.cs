using System;

namespace Proyecto_3
{
	/// <summary>
	/// Description of ComparaAlumnoDni.
	/// </summary>
	public class ComparaAlumnoDni : EstrategiaComparacionAlumno
	{
		public ComparaAlumnoDni()
		{
		}
		
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getDni()==a2.getDni();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getDni()>a2.getDni();

		}
		
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getDni()<a2.getDni();
						
		}
	}
}
