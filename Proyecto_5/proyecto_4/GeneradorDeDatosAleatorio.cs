using System;

namespace Proyecto_5
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorio.
	/// </summary>
	public class GeneradorDeDatosAleatorio
	{
		private int numeroAleatorio;
		
		
		public GeneradorDeDatosAleatorio(){
			
			
		}
		public int NumeroAleatorio(int max){
			return this.numeroAleatorio=Program.Aleatorio(max);
		}
		public string stringAleatorio(int cant=5){
			const string alfabeto = "abcdefghijklmnopqrstuvwxyz";
			string nombreal="";
			for (int i = 0; i < cant; i++) {
				nombreal=nombreal+alfabeto[Program.Aleatorio(25)];
			}
			return nombreal;
		}
	}
}
