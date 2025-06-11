using System;

namespace Proyecto_60
{
	/// <summary>
	/// Description of AlumnoProxy.
	/// </summary>
	public class AlumnoProxy : IAlumno , Comparable
	{
		private Alumno alumnoReal;
		private string nombreProxy;
		
		public AlumnoProxy(string n){
			this.nombreProxy=n;
		}
		
		public string getNombre(){
			//Console.WriteLine("Proxy");
			return this.nombreProxy;
		}
		
		public int getCalificacion(){
			if (alumnoReal==null) {
				alumnoReal=(Alumno)FabricaDeComparables.crearAleatorio(2);
			}
			return alumnoReal.getCalificacion();
		}
		
		public void setCalificacion(int cali){
			if (alumnoReal==null) {
				alumnoReal=(Alumno)FabricaDeComparables.crearAleatorio(2);
			}
			alumnoReal.setCalificacion(cali);
		}
		
		public void SetEstrategia(EstrategiaComparacionAlumno estra){
			if (alumnoReal==null) {
				alumnoReal=(Alumno)FabricaDeComparables.crearAleatorio(2);
			}
			alumnoReal.SetEstrategia(estra);
		}
		public int getLegajo(){
			if (alumnoReal==null) {
				alumnoReal=(Alumno)FabricaDeComparables.crearAleatorio(2);
			}
			return alumnoReal.getLegajo();
		}
		
		public int getDni(){
			if (alumnoReal==null) {
				alumnoReal=(Alumno)FabricaDeComparables.crearAleatorio(2);
			}
			return alumnoReal.getDni();
		}
		
		public double getPromedio(){
			if (alumnoReal==null) {
				alumnoReal=(Alumno)FabricaDeComparables.crearAleatorio(2);
			}
			return getPromedio();
		}
		
		public bool sosIgual(Comparable c){
			if (alumnoReal==null) {
				alumnoReal=(Alumno)FabricaDeComparables.crearAleatorio(2);
			}
			return alumnoReal.sosIgual(c);
		}
		
		public bool sosMenor(Comparable c){
			if (alumnoReal==null) {
				alumnoReal=(Alumno)FabricaDeComparables.crearAleatorio(2);
			}
			return alumnoReal.sosMenor(c);
		}
		
		public bool sosMayor(Comparable c){
			if (alumnoReal==null) {
				alumnoReal=(Alumno)FabricaDeComparables.crearAleatorio(2);
			}
			return alumnoReal.sosMayor(c);
		}
		
		public int responderPregunta(int pregunta){
			//Console.WriteLine("alumno real");
			if (alumnoReal==null) {
				alumnoReal=(Alumno)FabricaDeComparables.crearAleatorio(2);
			}
			return alumnoReal.responderPregunta(pregunta);
		}
		
		public string mostrarCalificacion(){
			if (alumnoReal==null) {
				alumnoReal=(Alumno)FabricaDeComparables.crearAleatorio(2);
			}
			return alumnoReal.mostrarCalificacion();
		}
	}
}
