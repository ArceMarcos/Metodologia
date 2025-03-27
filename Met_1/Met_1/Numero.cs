/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 23/3/2025
 * Time: 21:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Met_1
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
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
