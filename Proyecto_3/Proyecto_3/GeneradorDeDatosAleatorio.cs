﻿using System;

namespace Proyecto_3
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
			int indice;
			for (int i = 0; i < cant; i++) {
				indice=random.Next(0,25);
				nombreal=nombreal+alfabeto[indice];
			}
			return nombreal;
		}
	}
}
