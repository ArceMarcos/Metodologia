using System;

namespace Proyecto_4
{
	/// <summary>
	/// Description of ComparaAlumnoDni.
	/// </summary>
	public class ComparaAlumnoPromedio : EstrategiaComparacionAlumno
	{
		public ComparaAlumnoPromedio()
		{
		}
		
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getPromedio()==a2.getPromedio();
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getPromedio()<a2.getPromedio();

		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getPromedio()>a2.getPromedio();
						
		}
	}
}