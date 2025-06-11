using System;

namespace Proyecto_7
{
	/// <summary>
	/// Description of IteradorConjunto.
	/// </summary>
	public class IteradorConjunto : Iterador
	{
		private Conjunto c;
		private int indice;
		
		public IteradorConjunto(Conjunto c){
			this.c=c;
			primero();
		}
		
		public void primero(){
			this.indice=0;
		}
		
		public void siguiente(){
			this.indice++;
		}
		
		public bool fin(){
			return this.indice==this.c.cuantos();
		}
		
		public Comparable actual(){
			return this.c.getElemento((int)indice);
		}
	}
}
