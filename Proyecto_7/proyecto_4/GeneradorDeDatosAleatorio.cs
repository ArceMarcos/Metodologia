using System;

namespace Proyecto_7
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorio.
	/// </summary>
	public class GeneradorDeDatosAleatorio : Manejador
	{
		private static GeneradorDeDatosAleatorio gendatosAleatorios=null;
		
		private int numeroAleatorio;
		
		private GeneradorDeDatosAleatorio(Manejador m):base(m){
			
		}
		
		public static GeneradorDeDatosAleatorio getGeneradorDeDatosAleatorios(Manejador m){
			if (gendatosAleatorios==null) {
				gendatosAleatorios=new GeneradorDeDatosAleatorio(m);
			}
			return gendatosAleatorios;
		}
		
		public override int NumeroAleatorio(int max){
			return this.numeroAleatorio=Program.Aleatorio(max);
		}
		
		public override string stringAleatorio(int cant=5){
			const string alfabeto = "abcdefghijklmnopqrstuvwxyz";
			string nombreal="";
			for (int i = 0; i < cant; i++) {
				nombreal=nombreal+alfabeto[(int)Program.Aleatorio(25)];
			}
			return nombreal;
		}
	}
}
