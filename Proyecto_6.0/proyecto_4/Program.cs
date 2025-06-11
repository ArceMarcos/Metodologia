using System;
using System.Collections.Generic;

namespace Proyecto_60
{
	class Program
	{
		private static Random random=new Random();
		public static void Main(string[] args)
		{			
			Teacher teacher=new Teacher();
			IAlumno alumno;
			Student student;
			AlumnoCompuesto aluCompuesto=new AlumnoCompuesto();
			
			for (int i = 0; i < 5; i++) {
					alumno=new AlumnoProxy("Proxy");
					aluCompuesto.agregarAlumno(alumno);
			}
			
			AlumnoCompuestoAdapter alumCompAdap=new AlumnoCompuestoAdapter(aluCompuesto);
			Iterador iterador= alumCompAdap.CrearIterador();
			
			Pila pila=new Pila();
			Aula aula = new Aula();
  			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			
			iterador.primero();
			while (!iterador.fin()) {
				Console.WriteLine(1);
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