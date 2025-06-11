using System;

namespace Proyecto_6
{
	/// <summary>
	/// Description of AdivinaLaCarta.
	/// </summary>
	public class AdivinaLaCarta : JuegoDeCartas
	{
		
		protected override void repartir(){
			Console.WriteLine("Repartiendo cartas");
			
			while (!cartasVacias()) {
			darCarta(jugadores[0]);
			darCarta(jugadores[1]);	
			}
			while (jugadores[0].tieneCartas()||jugadores[1].tieneCartas()) {
				
				Console.WriteLine("Jugador: "+jugadores[1].getNroJugador()+" intente adivinar la carta entre las siguientes: ");
				
				foreach (int cartaActual in jugadores[0].getCartas()) {
					Console.Write(cartaActual+" - ");
				}
				Console.WriteLine();
				
				int cartaJugador1 = jugadores[0].quitarCarta(Program.Aleatorio(jugadores[0].cantidadDeCartas()));
				int prediccionJugador2=int.Parse(Console.ReadLine());
				
				if (cartaJugador1==prediccionJugador2) {
					jugadores[1].setPuntuacion(1);
					Console.WriteLine("Bien hecho ");
					Console.ReadKey();
				}
				
				Console.WriteLine("Jugador: "+jugadores[0].getNroJugador()+" intente adivinar la carta entre las siguientes: ");
				foreach (int cartaActual in jugadores[1].getCartas()) {
					Console.Write(cartaActual+" - ");
				}
				Console.WriteLine();
				
				int cartaJugador2 = jugadores[1].quitarCarta(Program.Aleatorio(jugadores[1].cantidadDeCartas()));
				int prediccionJugador1=int.Parse(Console.ReadLine());
				if (cartaJugador2==prediccionJugador1) {
					jugadores[0].setPuntuacion(1);
					Console.WriteLine("Bien hecho ");
					Console.ReadKey();
				}
				Console.Clear();
			}
			Console.WriteLine("Jugador "+jugadores[0].getNombre()+" tiene "+jugadores[0].getPuntuacion()+" puntos");
			Console.WriteLine("Jugador "+jugadores[1].getNombre()+" tiene "+jugadores[1].getPuntuacion()+" puntos");
			if (jugadores[0].getPuntuacion()>jugadores[1].getPuntuacion()) {
				Console.WriteLine("Ganador "+jugadores[0].getNombre());
			}
			if (jugadores[0].getPuntuacion()==jugadores[1].getPuntuacion()) {
				Console.WriteLine("EMPATE");
			}
			if (jugadores[0].getPuntuacion()<jugadores[1].getPuntuacion()) {
				Console.WriteLine("Ganador "+jugadores[1].getNombre());
			}
			fin=true;
			hayGanador();
		}
			
			
			
			
//			if (jugadores[0].quitarCarta(0)<jugadores[1].quitarCarta(0)) {
//				Console.WriteLine("Ganador jugador "+jugadores[1].getNombre());
//			}else{
//				Console.WriteLine("Ganador jugador "+jugadores[0].getNombre());
//			}
//			
//			Console.WriteLine("Fin del juego ");
//			fin=true;
//		}
		
		protected override void mezclar(){
			base.mezclar();
			Console.WriteLine("Adivina la carta");
		}
		
		protected override void agregarJugadores()
		{
			agregarJugador();
			agregarJugador();
		}
		
		protected override bool hayGanador(){
			return fin;
		}
	}
}
