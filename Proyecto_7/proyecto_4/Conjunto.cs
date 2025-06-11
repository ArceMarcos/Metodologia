
using System;
using System.Collections.Generic;

namespace Proyecto_7
{
	
	
	public class Conjunto : Coleccionable
	{
		List<Comparable> conjunto;
		
		public Conjunto()
		{
			conjunto=new List<Comparable>();
		}
		
		public Iterador CrearIterador(){
			Iterador ite=new IteradorConjunto(this);
			return ite;
		}
		
		public Comparable getElemento(int indice){
			return this.conjunto[indice];
		}
		
		public int cuantos(){
			return this.conjunto.Count;
		}
		public Comparable minimo(){
			Comparable minimoActual=this.conjunto[0];
			for (int i = 1; i < this.conjunto.Count; i++) {
				if (minimoActual.sosMenor(this.conjunto[i])) {
					minimoActual=conjunto[i];
				}
			}
			return minimoActual;
		}
		
		public Comparable maximo(){
			Comparable maximoActual=this.conjunto[0];
			for (int i = 1; i < this.conjunto.Count; i++) {
				if (maximoActual.sosMayor(this.conjunto[i])) {
					maximoActual=conjunto[i];
				}
			}
			return maximoActual;
		}
		public void agregar(Comparable c){
			if (!this.contiene(c)) {
				this.conjunto.Add(c);
			}
		}
		public bool contiene(Comparable c){
			for (int i = 0; i < conjunto.Count; i++) {
				if (this.conjunto[i].sosIgual(c)) {
					return true;
				}
			}
			return false;
		}
	}
}
