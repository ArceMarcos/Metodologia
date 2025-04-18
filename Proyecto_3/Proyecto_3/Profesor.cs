﻿using System;
using System.Collections.Generic;

namespace Proyecto_3
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor:Persona, Observado , Comparable
	{
		private int antiguedad;
		private bool hablando;	
		private List<Observador> observadores;
		
		public Profesor(string nombre,int dni,int a):base(nombre,dni){
			this.antiguedad=a;
			this.observadores=new List<Observador>();
		}
		
		public bool sosIgual(Comparable c){
			return this.antiguedad==((Profesor)c).antiguedad;
		}
		
		public bool sosMenor(Comparable c){
			return this.antiguedad > ((Profesor)c).antiguedad;

		}
		
		public bool sosMayor(Comparable c){
			return this.antiguedad < ((Profesor)c).antiguedad;
						
		}
		public void hablarALaClase(){
			Console.WriteLine("Hablando de algun tema ");
			this.hablando=true;
			this.notificar();
		}
		public void escribirEnElPizarron(){
			Console.WriteLine("Escribiendo en el pizarrón" );
			this.hablando=false;
			notificar();
		}
		
		public void agregarObservador(Observador o){
			this.observadores.Add(o);
		}
		
		public void quitar(Observador o){
			this.observadores.Remove(o);
		}
		
		public void notificar(){
			foreach (Observador observador in observadores) {
				observador.actualizar(this);
			}
		}
		public bool isHablando(){
			return this.hablando;	
		}
	}
}
