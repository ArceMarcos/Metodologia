using System;
using System.Collections.Generic;

namespace Proyecto_6
{
	/// <summary>
	/// Description of Jugador.
	/// </summary>
	public class Jugador
	{
		private string nombre;
		private List<int> cartas;
		private int numeroDeJugador;
		private int puntuacion; 
		
		public Jugador(string nom,int num){
			this.numeroDeJugador=num;
			this.nombre=nom;
			cartas=new List<int>();
		}
		
		public List<int> getCartas(){
			return this.cartas;
		}
		
		public bool tieneCartas(){
			return cartas.Count > 0;
		}
		
		public int getPuntuacion(){
			return this.puntuacion;
		}
		
		public void setPuntuacion(int pun){
			this.puntuacion=this.puntuacion+pun;
		}
		
		public int getNroJugador(){
			return this.numeroDeJugador;
		}
		
		public void setNroJugador(int num){
			this.numeroDeJugador=num;
		}
		
		public string getNombre(){
			return this.nombre;
		}
		
		public void setNombre(string nom){
			this.nombre=nom;
		}
		
		public void agregarCarta(int car){
			cartas.Add(car);
		}
		
		public int quitarCarta(int indice){
			int aux=cartas[indice];
			cartas.RemoveAt(indice);
			return aux;
		}
		public int cantidadDeCartas(){
			return cartas.Count;
		}
	}
}
