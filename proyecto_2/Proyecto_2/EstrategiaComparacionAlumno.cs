using System;

namespace proyecto_2
{
	public interface EstrategiaComparacionAlumno
	{
		bool sosIgual(Alumno a1, Alumno a2);
		
		bool sosMenor(Alumno a1, Alumno a2);
		
		bool sosMayor(Alumno a1, Alumno a2);
	}
}
