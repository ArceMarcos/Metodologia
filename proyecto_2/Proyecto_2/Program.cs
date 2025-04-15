using System;
using System.Collections.Generic;

namespace proyecto_2
{
	class Program
	{
		private static Random random=new Random();
		public static void Main(string[] args)
		{
			Pila pila=new Pila();
			Cola cola=new Cola();
			Conjunto conjunto=new Conjunto();
			EstrategiaComparacionAlumno estrategia;
			
			//ColeccionMultiple multiple=new ColeccionMultiple(pila,cola);
			
			//comparacion por promedio
			llenarAlumnos(conjunto);
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			informar(pila);
			informar(cola);
			informar(conjunto);
			
			//comparacion por legajo
			estrategia=new ComparaAlumnoLegajo();
			cambiarEstrategia(pila,estrategia);
			cambiarEstrategia(cola,estrategia);
			cambiarEstrategia(conjunto,estrategia);
			informar(pila);
			informar(cola);
			informar(conjunto);
			
			//comparacion por dni
			estrategia=new ComparaAlumnoDni();
			cambiarEstrategia(pila,estrategia);
			cambiarEstrategia(cola,estrategia);
			cambiarEstrategia(conjunto,estrategia);
			informar(pila);
			informar(cola);
			informar(conjunto);
			
			//comparacion por nombre
			estrategia=new ComparaAlumnoNombre();
			cambiarEstrategia(pila,estrategia);
			cambiarEstrategia(cola,estrategia);
			cambiarEstrategia(conjunto,estrategia);
			informar(pila);
			informar(cola);
			informar(conjunto);
			
			//imprimirElementos(cola);
			//imprimirElementos(conjunto);
			//informar(multiple);
			
			
			
//Probando los cambios
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static Coleccionable llenar(Coleccionable c){
			
			for (int i = 0; i < 20; i++) {
				Comparable comp=new Numero(random.Next(100));
				c.agregar(comp);
			}
			return c;
		}
		public static void informar(Coleccionable c){
			Console.WriteLine(c.cuantos());
			Console.WriteLine((Alumno)c.minimo());
			Console.WriteLine((Alumno)c.maximo());
			Console.WriteLine("ingrese un numero para buscar en la coleccion: ");
			Comparable com=new Alumno(int.Parse(Console.ReadLine()));
			if (c.contiene(com)) {
				Console.WriteLine("el elemento esta en la coleccion ");
			}
			else{
				Console.WriteLine("el elemento no esta en la coleccion ");
			}
		}
		public static Coleccionable llenarAlumnos(Coleccionable c){
			
			for (int i = 0; i < 20; i++) {
				Comparable comp=new Alumno("nombre alAzar",random.Next(70000),random.Next(500),random.Next(10));
				c.agregar(comp);
			}
			return c;
		}	
		public static void imprimirElementos(Coleccionable c){
			Iterador ite=c.CrearIterador();
			ite.primero();
			while (!ite.fin()) {
				Console.WriteLine(ite.actual());
				ite.siguiente();
			}
			
		}
		
		public static Coleccionable cambiarEstrategia(Coleccionable c,EstrategiaComparacionAlumno e){
			Iterador ite=c.CrearIterador();
			ite.primero();
			while (!ite.fin()) {
				((Alumno)ite.actual()).SetEstrategia(e);
				ite.siguiente();
			}
			
			return c;
		}
			
	}
}