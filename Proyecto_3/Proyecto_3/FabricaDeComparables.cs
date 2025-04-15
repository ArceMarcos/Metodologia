using System;

namespace Proyecto_3
{

	public abstract class FabricaDeComparables
	{
		protected GeneradorDeDatosAleatorio gen=new GeneradorDeDatosAleatorio();
		protected LectorDeDatos lec =new LectorDeDatos();
		
		FabricaDeComparables fabrica =null;
		
		//metodos de clase
		
		public static Comparable crearAleatorio(int opcion){
			FabricaDeComparables fabrica =null;
			switch (opcion) {
					case 1: fabrica = new FabricaDeNumeros();break;
					case 2: fabrica = new FabricaDeAlumnos();break;
			}
			
			return fabrica.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int opcion){
			FabricaDeComparables fabrica =null;
			switch (opcion) {
					case 1: fabrica = new FabricaDeNumeros();break;
					case 2: fabrica = new FabricaDeAlumnos();break;
			}
			
			return fabrica.crearPorTeclado();
		}
		
		//metodos de instancia
		
		public abstract Comparable crearAleatorio();
		
		public abstract Comparable crearPorTeclado();
		
	}
}
