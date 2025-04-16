using System;

namespace Proyecto_4
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorio.
	/// </summary>
	public class GeneradorDeDatosAleatorio
	{
		private Random random=new Random();
		private int numeroAleatorio;
		
		
		public GeneradorDeDatosAleatorio(){
			
			
		}
		public int NumeroAleatorio(int max){
			return this.numeroAleatorio=random.Next(0,max);
		}
		public string stringAleatorio(int cant=5){
			const string alfabeto = "abcdefghijklmnopqrstuvwxyz";
			string nombreal="";
			for (int i = 0; i < cant; i++) {
				nombreal=nombreal+alfabeto[random.Next(0,25)];
			}
			return nombreal;
		}
	}
}
