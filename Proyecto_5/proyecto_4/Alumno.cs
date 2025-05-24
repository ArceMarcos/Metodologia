using System;

namespace Proyecto_5
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona,Comparable, Observador, IAlumno
	{
		protected int calificacion;
		protected int legajo;
		protected double promedio;
		protected EstrategiaComparacionAlumno estrategia;
		
		
		public Alumno(string nombre,int dni,int legajo,double promedio): base (nombre, dni){
			this.nombre=nombre;
			this.dni=dni;
			this.legajo=legajo;
			this.promedio=promedio;
			this.estrategia=new ComparaAlumnoNombre();
		}
		public int getCalificacion(){
			return this.calificacion;
		}
		
		public void setCalificacion(int cali){
			this.calificacion=cali;
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
			return estrategia.sosIgual(this,((IAlumno)c));
		}
		
		public void prestarAtencion(){
			Console.WriteLine("Prestando atencion ");
		}
		
		public void distraerse(){
			Console.WriteLine("Mirando el celular ");
		}
		
		public override bool sosMenor(Comparable c){
			return estrategia.sosMenor(this,((IAlumno)c));

		}
		
		public override bool sosMayor(Comparable c){
			return estrategia.sosMayor(this,((IAlumno)c));
		}
		
		public void actualizar(Observado o){
			if (((Profesor)o).isHablando()){
				this.prestarAtencion();
			}else{
				this.distraerse();
			}
		}
		
		public override string ToString(){
			return "Alumno: " + getNombre() + "      DNI: " + getDni() + "       Legajo: "+this.legajo+"      Promedio: "+this.promedio;
		}
		
		public virtual int responderPregunta(int pregunta){
			int respuesta=Program.Aleatorio(3);
			return pregunta%(respuesta+1);
		}
		public string mostrarCalificacion(){
			return getNombre()+"   "+getCalificacion();
		}
	}
}