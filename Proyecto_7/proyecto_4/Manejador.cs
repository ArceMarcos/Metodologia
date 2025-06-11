/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 5/6/2025
 * Time: 06:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_7
{
	
	public abstract class Manejador
	{
		Manejador sucesor = null;
		
		public Manejador(Manejador s){
			this.sucesor=s;
		}
		
		public virtual int NumeroAleatorio(int max){
			int aux=0;
			if (sucesor!=null) {
				aux=sucesor.NumeroAleatorio(max);
			}
			return aux;
		}
		
		public virtual string stringAleatorio(int cant=5){
			string aux="";
			if (sucesor!=null) {
				aux=sucesor.stringAleatorio(cant);
			}
			return aux;
		}
		
		public virtual int numeroPorTeclado(){
			int aux=0;
			if (sucesor!=null) {
				aux=sucesor.numeroPorTeclado();
			}
			return aux;
		}
		
		public virtual string stringPorTeclado(){
			string aux="";
			if (sucesor!=null) {
				aux=sucesor.stringPorTeclado();
			}
			return aux;
		}
		
		public virtual double numeroDesdeArchivo(int max){
			double aux =0;
			if (sucesor!=null) {
				aux=sucesor.numeroDesdeArchivo(max);
			}
			return aux;
		}
		
		public virtual string stringDesdeArchivo(int cant){
			string aux="";
			if (sucesor!=null) {
				aux=sucesor.stringDesdeArchivo(cant);
			}
			return aux;
		}
		
	}
}
