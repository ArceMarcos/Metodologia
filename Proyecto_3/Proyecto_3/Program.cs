using System;
using System.Collections.Generic;

namespace Proyecto_3
{
	class Program
	{
		private static Random random=new Random();
		public static void Main(string[] args)
		{
			
			Profesor profe = new Profesor("Marcos",12456789,1);
			
			Pila pila=new Pila();
			llenar(pila,2);
			Iterador iterador = pila.CrearIterador();
			
			iterador.primero();
			while (!iterador.fin()) {
				profe.agregarObservador((Observador)iterador.actual());
				iterador.siguiente();
			}
			
			dictadoDeClase(profe);
			imprimirElementos(pila);
						
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static Coleccionable llenar(Coleccionable c,int opcion){
			
			for (int i = 0; i < 20; i++) {
				Comparable comp=FabricaDeComparables.crearAleatorio(opcion);
				c.agregar(comp);
			}
			return c;
		}
		public static void informar(Coleccionable c,int opcion){
			
			Console.WriteLine(c.cuantos());
			Console.WriteLine(c.minimo());
			Console.WriteLine(c.maximo());
			
			//Console.WriteLine("ingrese un numero para buscar en la coleccion: ");
			
			Comparable com=FabricaDeComparables.crearPorTeclado(opcion);
			
			if (c.contiene(com)) {
				Console.WriteLine("el elemento esta en la coleccion ");
			}
			else{
				Console.WriteLine("el elemento no esta en la coleccion ");
			}
		}
		
//		public static Coleccionable llenarAlumnos(Coleccionable c){
//			
//			for (int i = 0; i < 20; i++) {
//				Comparable comp=new Alumno("nombre alAzar",random.Next(70000),random.Next(500),random.Next(10));
//				c.agregar(comp);
//			}
//			return c;
//		}	
		
		public static void imprimirElementos(Coleccionable c){
			Iterador ite=c.CrearIterador();
			ite.primero();
			while (!ite.fin()) {
				Console.WriteLine(ite.actual());
				ite.siguiente();
			}
			
		}
		
		public static void dictadoDeClase(Profesor profe){
			for (int i = 0; i < 5; i++) {
				profe.hablarALaClase();
				profe.escribirEnElPizarron();
			}
		}
			
	}
}