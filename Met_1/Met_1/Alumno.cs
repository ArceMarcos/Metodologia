using System;

namespace Met_1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona,Comparable
	{
		private int legajo;
		private int promedio;
		
		public Alumno(int promedio){
			this.promedio=promedio;
		}
		public Alumno(string nombre,int dni,int legajo,int promedio): base (nombre, dni){
			this.nombre=nombre;
			this.dni=dni;
			this.legajo=legajo;
			this.promedio=promedio;
		}
		public int getLegajo(){
			return this.legajo;
		}
		public int getPromedio(){
			return this.promedio;
		}
		public override bool sosIgual(Comparable c){
			return this.promedio==((Alumno)c).getPromedio();
		}
		
		public override bool sosMenor(Comparable c){
			return this.promedio<((Alumno)c).getPromedio();

		}
		
		public override bool sosMayor(Comparable c){
			return this.promedio>((Alumno)c).getPromedio();
						
		}
		
	}
}
