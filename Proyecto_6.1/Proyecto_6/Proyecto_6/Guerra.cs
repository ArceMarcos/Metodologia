using System;

namespace Proyecto_6
{
	public class Guerra : JuegoDeCartas
	{
		
		protected override bool hayGanador(){
			return fin;
		}
		
		protected override void repartir(){
			Console.WriteLine("Repartiendo cartas");
			
			while (!cartasVacias()) {
			darCarta(jugadores[0]);
			darCarta(jugadores[1]);	
			}
			
			if (jugadores[0].quitarCarta(0)<jugadores[1].quitarCarta(0)) {
				Console.WriteLine("Ganador jugador "+jugadores[1].getNombre());
			}else{
				Console.WriteLine("Ganador jugador "+jugadores[0].getNombre());
			}
			
			Console.WriteLine("Fin del juego ");
			fin=true;
		}
	
		protected override void agregarJugadores()
		{
			agregarJugador();
			agregarJugador();
		}
		
		protected override void mezclar(){
			base.mezclar();
			Console.WriteLine("la guerra");
		}
	
	}
}