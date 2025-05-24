using System;

namespace Proyecto_5
{
	/// <summary>
	/// Description of ComparaAlumnoDni.
	/// </summary>
	public class ComparaAlumnoDni : EstrategiaComparacionAlumno
	{
		public ComparaAlumnoDni()
		{
		}
		
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getDni()==a2.getDni();
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getDni()>a2.getDni();

		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getDni()<a2.getDni();
						
		}
	}
}
