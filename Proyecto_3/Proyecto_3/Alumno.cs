using System;

namespace Proyecto_3
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona,Comparable, Observador
	{
		private int legajo;
		private double promedio;
		private EstrategiaComparacionAlumno estrategia;
		
		public Alumno(int promedio){
			this.promedio=promedio;
			this.estrategia=new ComparaAlumnoPromedio();
		}
		
		public Alumno(string nombre,int dni,int legajo,double promedio): base (nombre, dni){
			this.nombre=nombre;
			this.dni=dni;
			this.legajo=legajo;
			this.promedio=promedio;
			this.estrategia=new ComparaAlumnoPromedio();
		}
		
		public void SetEstrategia(EstrategiaComparacionAlumno estra){
			this.estrategia=estra;
		}
		public int getLegajo(){
			return this.legajo;
		}
		public double getPromedio(){
			return this.promedio;
		}
		public override bool sosIgual(Comparable c){
			return estrategia.sosIgual(this,((Alumno)c));
		}
		
		public void prestarAtencion(){
			Console.WriteLine("Prestando atencion ");
		}
		
		public void distraerse(){
			Console.WriteLine("Mirando el celular ");
		}
		
		public override bool sosMenor(Comparable c){
			return estrategia.sosMenor(this,((Alumno)c));

		}
		
		public override bool sosMayor(Comparable c){
			return estrategia.sosMayor(this,((Alumno)c));
		}
		
		public void actualizar(Observado o){
			if (((Profesor)o).isHablando()){
				this.prestarAtencion();
			}else{
				this.distraerse();
			}
		}
		
		public override string ToString(){
			return "Alumno: " + getNombre() + " DNI: " + getDni() + "Legajo: "+this.legajo+"Promedio: "+this.promedio;
		}
	}
}