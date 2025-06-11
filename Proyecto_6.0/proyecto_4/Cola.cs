using System;
using System.Collections.Generic;

namespace Proyecto_60
{

	public class Cola : Coleccionable , Ordenable
	{
		private List<Comparable>lista;
		OrdenEnAula1 ordenInicio, ordenAulaLlena;
		OrdenEnAula2 ordenLlegaAlumno;
		
		public Cola(){
			this.lista=new List<Comparable>();
		}
		
		public Iterador CrearIterador(){
			Iterador ite=new IteradorCola(this);
			return ite;
		}
		
		public Comparable getElemento(int indice){
			return this.lista[indice];
		}
		
		public void encolar(Comparable c){
			this.lista.Add(c);
			
			if (this.lista.Count == 1 && ordenInicio != null){
				ordenInicio.ejecutar();
			}
			
			if (ordenLlegaAlumno != null) {
				ordenLlegaAlumno.ejecutar(c);
			}
			
			if (this.lista.Count == 40 && ordenAulaLlena != null) {
				ordenAulaLlena.ejecutar();
			}
		}
		
		public Comparable desencolar(Cola c){
			Comparable aux=c.lista[0];
			c.lista.RemoveAt(0);
			return aux;
		}
		
		public int cuantos(){
			return this.lista.Count;
		}
		
		public Comparable minimo(){
			Comparable minimoActual=this.lista[0];
			for (int i = 1; i < this.lista.Count; i++) {
				if (minimoActual.sosMenor(this.lista[i])) {
					minimoActual=lista[i];
				}
			}
			return minimoActual;
		}
		
		public Comparable maximo(){
			Comparable maximoActual=this.lista[0];
			for (int i = 1; i < this.lista.Count; i++) {
				if (maximoActual.sosMayor(this.lista[i])) {
					maximoActual=lista[i];
				}
			}
			return maximoActual;
		}
		
		public void agregar(Comparable c){
			encolar(c);
		}
		public bool contiene(Comparable c){
			for (int i = 0; i < lista.Count; i++) {
				if (this.lista[i].sosIgual(c)) {
					return true;
				}
			}
			return false;
		}
		
		public void setOrdenInicio(OrdenEnAula1 o){
			this.ordenInicio=o;
		}
		public void setOrdenLlegaAlumno(OrdenEnAula2 o){
			this.ordenLlegaAlumno=o;
		}
		public void setOrdenAulaLlena(OrdenEnAula1 o){
			this.ordenAulaLlena=o;
		}
	}
}
