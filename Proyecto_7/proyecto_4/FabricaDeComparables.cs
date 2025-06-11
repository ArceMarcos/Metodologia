using System;

namespace Proyecto_7
{

	public abstract class FabricaDeComparables
	{
	
		
		FabricaDeComparables fabrica =null;
		protected Manejador m=crearCadenaDeResponsabilidades();
		//metodos de clase
		
		public static Comparable crearAleatorio(int opcion){
			FabricaDeComparables fabrica =null;
			switch (opcion) {
					case 1: fabrica = new FabricaDeNumeros();break;
					case 2: fabrica = new FabricaDeAlumnos();break;
					case 3: fabrica = new FabricaDeAlumnosMuyEstudiosos();break;
			}
			
			return fabrica.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int opcion){
			FabricaDeComparables fabrica =null;
			switch (opcion) {
					case 1: fabrica = new FabricaDeNumeros();break;
					case 2: fabrica = new FabricaDeAlumnos();break;
					case 3: fabrica = new FabricaDeAlumnosMuyEstudiosos();break;
			}
			
			return fabrica.crearPorTeclado();
		}
		
		public static Comparable crearDesdeArchivo(int opcion){
			FabricaDeComparables fabrica =null;
			switch (opcion) {
					case 1: fabrica = new FabricaDeNumeros();break;
					case 2: fabrica = new FabricaDeAlumnos();break;
					case 3: fabrica = new FabricaDeAlumnosMuyEstudiosos();break;
			}
			
			return fabrica.crearDesdeArchivo();
		}
		
		private static Manejador crearCadenaDeResponsabilidades(){
			Manejador m =GeneradorDeDatosAleatorio.getGeneradorDeDatosAleatorios(null);
			m=new LectorDeDatos(m);
			m=LectorDeArchivos.getLectorDeArchivos(m);
			return m;
		}
		
		//metodos de instancia
		
		public abstract Comparable crearAleatorio();
		
		public abstract Comparable crearPorTeclado();
		
		public abstract Comparable crearDesdeArchivo();
		
	}
}
