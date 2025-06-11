using System;
using System.Collections.Generic;

namespace Proyecto_7
{

	public class ColeccionMultiple //: Coleccionable
	{
		private Pila pila;
		private Cola cola;
		
		public ColeccionMultiple(Pila p,Cola c){
			this.pila=p;
			this.cola=c;
		}
		
//		public Iterador CrearIterador(){
//			Iterador ite=new IteradorPila(this);
//			return ite;
//		}
//		
		public int cuantos(){
			return pila.cuantos() + cola.cuantos();
		}
		public Comparable minimo(){
			if (pila.minimo().sosMayor(cola.minimo())) {
				return pila.minimo();
		}	
			return cola.minimo();
		}
		
		public Comparable maximo(){
			if (pila.maximo().sosMenor(cola.maximo())) {
				return pila.maximo();
		}	
			return cola.maximo();
		}
		public void agregar(Comparable c){
			
		}
		
		public bool contiene(Comparable c){
			if (pila.contiene(c)||cola.contiene(c)) {
				return true;
			}
			else{
				return false;
			}
		}

		
	}
}
