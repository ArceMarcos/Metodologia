using System;

namespace Proyecto_7
{
	/// <summary>
	/// Description of ComparaAlumnoDni.
	/// </summary>
	public class ComparaAlumnoLegajo : EstrategiaComparacionAlumno
	{
		public ComparaAlumnoLegajo()
		{
		}
		
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getLegajo()==a2.getLegajo();
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getLegajo()<a2.getLegajo();

		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getLegajo()>a2.getLegajo();
						
		}
	}
}