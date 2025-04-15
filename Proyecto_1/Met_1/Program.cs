using System;
using System.Collections.Generic;

namespace proyecto_1
{
	class Program
	{
		private static Random random=new Random();
		public static void Main(string[] args)
		{
			Pila pila=new Pila();
			Cola cola=new Cola();
			ColeccionMultiple multiple=new ColeccionMultiple(pila,cola);
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			informar(pila);
			informar(cola);
			informar(multiple);
			
			
			

			
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
			Console.WriteLine(((Alumno)c.minimo()).getPromedio());
			Console.WriteLine(((Alumno)c.maximo()).getPromedio());
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
		
			
	}
}