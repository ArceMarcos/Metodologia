using System;
using System.Collections.Generic;

namespace Proyecto_7
{
	class Program
	{
		private static Random random=new Random();
		public static void Main(string[] args)
		{			
			IAlumno alumno;
			AlumnoCompuesto aluCompuesto=new AlumnoCompuesto();
			Pila pila=new Pila();
			Aula aula = new Aula();
			
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			
			for (int i = 0; i < 12; i++) {
				if (i<5) {
					alumno=(IAlumno)FabricaDeComparables.crearDesdeArchivo(2);
					aluCompuesto.agregarAlumno(alumno);
				}
				if (i>=5 && i<10) {
					alumno=(IAlumno)FabricaDeComparables.crearAleatorio(2);
					pila.agregar((Comparable)alumno);
				}
				if (i>=10) {
					alumno=(IAlumno)FabricaDeComparables.crearAleatorio(3);
					pila.agregar((Comparable)alumno);
				}
			}
			
			AlumnoCompuestoAdapter alumCompAdap=new AlumnoCompuestoAdapter(aluCompuesto);
			Iterador iterador= alumCompAdap.CrearIterador();
			
  			
			
			iterador.primero();
			while (!iterador.fin()) {
				pila.agregar(iterador.actual());
				iterador.siguiente();
			}

			Console.ReadKey();
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
		public static int Aleatorio(int entero){
			int aleatorio=random.Next(0,entero);
			return aleatorio;
		}
			
	}
}