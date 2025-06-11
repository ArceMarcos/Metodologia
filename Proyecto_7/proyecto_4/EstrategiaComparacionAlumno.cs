using System;

namespace Proyecto_7
{
	public interface EstrategiaComparacionAlumno
	{
		bool sosIgual(IAlumno a1, IAlumno a2);
		
		bool sosMenor(IAlumno a1, IAlumno a2);
		
		bool sosMayor(IAlumno a1, IAlumno a2);
	}
}
