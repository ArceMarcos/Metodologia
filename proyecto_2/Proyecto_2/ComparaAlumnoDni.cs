/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 1/4/2025
 * Time: 20:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyecto_2
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
