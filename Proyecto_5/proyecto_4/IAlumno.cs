using System;

namespace Proyecto_5
{

	 public interface IAlumno 
	{
	 	string getNombre();
	 	int getCalificacion();
	 	void setCalificacion(int cali);
	 	void SetEstrategia(EstrategiaComparacionAlumno estra);
	 	int getLegajo();
	 	int getDni();
	 	double getPromedio();
	 	bool sosIgual(Comparable c);
	 	bool sosMenor(Comparable c);
	 	bool sosMayor(Comparable c);
	 	int responderPregunta(int pregunta);
	 	string mostrarCalificacion();
	}
}
