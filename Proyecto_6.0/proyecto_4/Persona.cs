using System;

namespace Proyecto_60
{
	public abstract class Persona : Comparable
	{
		protected string nombre;
		protected int dni;
		public Persona(){}
		public Persona(string nombre,int dni){
			this.nombre=nombre;
			this.dni=dni;
		}
		
		public string getNombre(){
			return this.nombre;
		}
		public int getDni(){
			return this.dni;
		}
		public virtual bool sosIgual(Comparable c){
			return this.dni==((Persona)c).getDni();
		}
		
		public virtual bool sosMenor(Comparable c){
			return this.dni>((Persona)c).getDni();

		}
		
		public virtual bool sosMayor(Comparable c){
			 return this.dni<((Persona)c).getDni();
						
		}
		
	}
}

