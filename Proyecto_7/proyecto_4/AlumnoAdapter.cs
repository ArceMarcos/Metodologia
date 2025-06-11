using System;

namespace Proyecto_7
{
	
	public class AlumnoAdapter : IAlumno ,Student, Comparable,IAlumnoAdapterDecorado
	{
		IAlumno alumno;
		
		public AlumnoAdapter(IAlumno a){
			alumno = a;
		}
		
		public IAlumno getAlumno(){
			return this.alumno;
		}
		
		public string getName(){
			return alumno.getNombre();
		}
		
		public int yourAnswerIs(int question){
			return alumno.responderPregunta(question);
		}
		
		public void setScore(int score){
			alumno.setCalificacion(score);
		}
		
		public string showResult(){
			return alumno.mostrarCalificacion();
		}
		
		public bool equals(Student student){
			return alumno.sosIgual((AlumnoAdapter)student);
		}
		public bool lessThan(Student student){
			return alumno.sosMenor((AlumnoAdapter)student);
		}
		public bool greaterThan(Student student){
			return alumno.sosMayor((AlumnoAdapter)student);
		}
		
		public bool sosIgual(Comparable c){
			return alumno.sosIgual(c);
		}

		public bool sosMenor(Comparable c){
			return alumno.sosMenor(c);
		}    
		
		public bool sosMayor(Comparable c){
			return alumno.sosMayor(c);
		}
		
		public int getCalificacion(){
			return alumno.getCalificacion();
		}
		
		public void setCalificacion(int cali){
			alumno.setCalificacion(cali);
		}
		
		public void SetEstrategia(EstrategiaComparacionAlumno estra){
			alumno.SetEstrategia(estra);
		}
		
		public int getLegajo(){
			return	alumno.getLegajo();
		}
		
		public int getPromedio(){
			return alumno.getPromedio();
		}

	 	public int responderPregunta(int pregunta){
	 		return alumno.responderPregunta(pregunta);
	 	}
		
	 	public string mostrarCalificacion(){
	 		return alumno.mostrarCalificacion();
	 	}
		
	 	public string getNombre(){
	 		return alumno.getNombre();
	 	}
		public int getDni(){
			return alumno.getDni();
		}
	}
}
