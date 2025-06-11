using System;

namespace Proyecto_60
{
	/// <summary>
	/// Description of IteradorPila.
	/// </summary>
	public class IteradorPila : Iterador
	{
		private Pila p;
		private int indice;
		
		public IteradorPila(Pila p){
			this.p=p;
			primero();			
		}
		
		public void primero(){
			this.indice=this.p.cuantos()-1;
		}
		public void siguiente(){
			this.indice--;
		}
		public bool fin(){
			return this.indice<0;
		}
		public Comparable actual(){
			return this.p.getElemento(indice);
		}
	}
}