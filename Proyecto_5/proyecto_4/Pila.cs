using System;
using System.Collections.Generic;

namespace Proyecto_5
{

	public class Pila : Coleccionable
	{
		
		private List<Comparable>pila;
		public Pila(){
			pila=new List<Comparable>();
		}
		
		public Iterador CrearIterador(){
			Iterador ite=new IteradorPila(this);
			return ite;
		}
		
		public Comparable getElemento(int indice){
			return this.pila[indice];
		}
		
		public void apilar(Comparable c){
			this.pila.Add(c);
		}
		public Comparable desapilar(){
			Comparable aux=this.pila[this.pila.Count-1];
			pila.RemoveAt(this.pila.Count-1);
			return aux;
		}
		
		public int cuantos(){
			return this.pila.Count;
		}
		
		public Comparable minimo(){
			Comparable minimoActual=this.pila[0];
			for (int i = 1; i < this.pila.Count; i++) {
				if (minimoActual.sosMenor(this.pila[i])) {
					minimoActual=pila[i];
				}
			}
			return minimoActual;
		}
		
		public Comparable maximo(){
			Comparable maximoActual=this.pila[0];
			for (int i = 1; i < this.pila.Count; i++) {
				if (maximoActual.sosMayor(this.pila[i])) {
					maximoActual=pila[i];
				}
			}
			return maximoActual;
		}
		
		public void agregar(Comparable c){
			apilar(c);
		}
		public bool contiene(Comparable c){
			for (int i = 0; i < pila.Count; i++) {
				if (this.pila[i].sosIgual(c)) {
					return true;
				}
			}
			return false;
		}
	}
}
