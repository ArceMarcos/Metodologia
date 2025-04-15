using System;

namespace proyecto_2
{
	/// <summary>
	/// Description of IteradorCola.
	/// </summary>
	public class IteradorCola : Iterador
	{
		private Cola c;
		private int indice;
		
		public IteradorCola(Cola c){
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
			return this.c.getElemento(indice);
		}
	}
}
