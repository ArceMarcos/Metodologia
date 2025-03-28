using System;
using System.Collections.Generic;

namespace Met_1
{

	public class Cola : Coleccionable
	{
		private List<Comparable>lista;
		
		public Cola(){
			this.lista=new List<Comparable>();
		}
		
		public void encolar(Comparable c){
			this.lista.Add(c);
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
	}
}
