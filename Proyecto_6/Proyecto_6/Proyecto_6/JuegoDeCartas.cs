using System;
using System.Collections.Generic;
namespace Proyecto_6
{
	public abstract class JuegoDeCartas
	{
		protected List<Jugador>jugadores;
		protected List<int> cartas;
		protected bool fin;
		
		public JuegoDeCartas(){
			cartas=new List<int>();
			jugadores=new List<Jugador>();
		}
		
		public void jugar(){
			mezclar();
			agregarJugadores();
			repartir();
			while (!hayGanador()) {
				repartir();
			}
		}
		
		protected virtual void mezclar(){
			Console.Write("Mezclando cartas para jugar a ");
			cartas.Clear();
			for (int i = 0; i < 10; i++) {
				//for (int j = 0; j < 3; j++) {
					cartas.Add(i+1);
				//}
			}
		}
		protected bool cartasVacias(){
			return cartas.Count==0;
		}
		protected void agregarJugador(){
			Console.Write("Ingrese nombre del jugador "+(jugadores.Count+1)+" : ");
			string jug=Console.ReadLine();
			Console.WriteLine();
			Jugador jugador=new Jugador(jug,jugadores.Count);
			jugadores.Add(jugador);
		}
		
		protected void darCarta(Jugador jug){
			int aux=Program.Aleatorio(cartas.Count-1);
			jug.agregarCarta(cartas[aux]);
			cartas.RemoveAt(aux);
		}
		
		protected abstract void agregarJugadores();
		protected abstract bool hayGanador();
		protected abstract void repartir();
	}
}
