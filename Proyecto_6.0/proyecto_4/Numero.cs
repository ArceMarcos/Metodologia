using System;

namespace Proyecto_60
{

	public class Numero : Comparable
	{
		private int valor;
		
		public Numero(int v){	
			this.valor=v;
		}
		
		public int getValor(){
			return this.valor;
		}
		
		public bool sosIgual(Comparable c){
			return this.valor==((Numero)c).valor;
		}
		
		public bool sosMenor(Comparable c){
			return this.valor > ((Numero)c).valor;

		}
		
		public bool sosMayor(Comparable c){
			return this.valor < ((Numero)c).valor;
						
		}
		
	}

}