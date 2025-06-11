using System;

namespace Proyecto_6
{
	class Program
	{
		private static Random random=new Random();
		public static void Main(string[] args)
		{
			JuegoDeCartas juego=new AdivinaLaCarta();
			JuegoDeCartas juego1=new Guerra();
			juego.jugar();
			
			Console.ReadKey(true);
		}
		
		public static int Aleatorio(int entero){
			int aleatorio=random.Next(0,entero);
			return aleatorio;
		}
	}
}