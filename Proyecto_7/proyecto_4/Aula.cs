using System;

namespace Proyecto_7
{
	
	public class Aula
	{
		private Teacher teacher;
		
		public Aula(){}
		
		public void comenzar(){
			this.teacher=new Teacher();
		}
		
		public void nuevoAlumno(IAlumno alumno){
			this.teacher.goToClass(new AlumnoAdapter(alumno));
		}
		public void claseLista(){
			this.teacher.teachingAClass();
		}
	}
}
