using System;
using System.Collections.Generic;

namespace Proyecto_5
{
	class Program
	{
		private static Random random=new Random();
		public static void Main(string[] args)
		{
			//Patron proxy
			
			Teacher teacher=new Teacher();
			IAlumno alumno;
			Student student;
			
			for (int i = 0; i < 40; i++) {
				if (i<20) {
					alumno=new AlumnoProxy("Proxy");
					student=new AlumnoAdapter(alumno);
					teacher.goToClass(student);
				}
			}
			teacher.teachingAClass();
			
			Console.ReadKey();
			Console.Clear();
			//Patron Command
			
			Pila pila= new Pila();
			Cola cola = new Cola();
			Aula aula = new Aula();
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
//			cola.setOrdenInicio(new OrdenInicio(aula));
//			cola.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
//			cola.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			llenar(pila,2);
			llenar(pila,3);
			llenar(cola,3);
			llenar(cola,2);


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