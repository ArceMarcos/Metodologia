using System;

namespace Proyecto_4
{
	
	public class AlumnoAdapter : IAlumno ,Student, Comparable,IAlumnoAdapterDecorado
	{
		Alumno alumno;
		
		public AlumnoAdapter(Alumno a){
			alumno = a;
		}
		
		public Alumno getAlumno(){
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
		
//		public bool equals(Student student){
//			return alumno.sosIgual((Comparable)student);
//		}
//		public bool lessThan(Student student){
//			return alumno.sosMenor((Comparable)student);
//		}
//		public bool greaterThan(Student student){
//			return alumno.sosMayor((Comparable)student);
//			
//		}
		
		public bool equals(Student student){
			Alumno aluaux=new Alumno(student.getName(),0,0,0);
			return alumno.sosIgual(aluaux);			
		}
		public bool lessThan(Student student){
			Alumno aluaux=new Alumno(student.getName(),0,0,0);
			return alumno.sosMenor(aluaux);
		}
		public bool greaterThan(Student student){
			Alumno aluaux=new Alumno(student.getName(),0,0,0);
			return alumno.sosMayor(aluaux);
			
		}
		
		public bool sosIgual(Comparable c){
			return alumno.sosIgual((((AlumnoAdapter)c).getAlumno()));
		}

		public bool sosMenor(Comparable c){
			return alumno.sosMenor((((AlumnoAdapter)c).getAlumno()));
		}    
		
		public bool sosMayor(Comparable c){
			return alumno.sosMayor((((AlumnoAdapter)c).getAlumno()));
		}
			
	}
}
