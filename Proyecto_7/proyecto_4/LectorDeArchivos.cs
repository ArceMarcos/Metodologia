/*
 * Created by Metodologías de Programación I
 * Activity 7. 
 * Chain of responsability and Singleton patterns 
 *
 * Antes de usar este código el alumno deberá agregar a la variable "ruta_archivo" de la clase 
 * "LectorDeArchivos" la ruta correspondiente a su equipo donde haya guardado el archivo con los datos
 * provistos por la cátedra (archivo datos.txt)
 *
 * IMPORTANTE *  
 * El código que está en este archivo SI puede modificarse para resolver la actividad solicitada
 * 
 */

using System;
using System.IO;

namespace Proyecto_7
{
	public class LectorDeArchivos : Manejador
	{
		
		// El alumno deberá agregar la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
		private const string ruta_archivo = @"D:\Users\Estan\Desktop\Documentación  Marcos\repositorio-git-MyP\Proyecto_7\proyecto_4\datos.txt";
		// --------------------------------------------------------------------------------------------------------
		
		//Declaro el objeto static LectorDeArchivo que es privado
		private static LectorDeArchivos lectorDeArchivos=null;
				
		private StreamReader lector_de_archivos;
		
		//Para hecr uso de singleton el constructor lo declaro private
		private LectorDeArchivos(Manejador m):base(m){
			lector_de_archivos = new StreamReader(ruta_archivo);
		}
		
		//Creo el metodo static para crear el objeto que en caso de ya estar creado no lo repite
		public static LectorDeArchivos getLectorDeArchivos(Manejador m){
			if (lectorDeArchivos==null) {
				lectorDeArchivos=new LectorDeArchivos(m);
			}
			return lectorDeArchivos;
		}
		
		public override double numeroDesdeArchivo(int max){
			string linea = lector_de_archivos.ReadLine();
			return double.Parse(linea.Substring(0, linea.IndexOf('\t'))) * max;
		}
		
		public override string stringDesdeArchivo(int cant){
			string linea = lector_de_archivos.ReadLine();
			linea = linea.Substring(linea.IndexOf('\t')+1);
			cant = Math.Min(cant, linea.Length);
			return linea.Substring(0, cant);
		}
	}
}
