/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 4/6/2025
 * Time: 06:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_7
{
	/// <summary>
	/// Description of AlumnoCompuestoAdapter.
	/// </summary>
	public class AlumnoCompuestoAdapter: Coleccionable
	{
		private AlumnoCompuesto alumnoCompuesto;
		
		public AlumnoCompuestoAdapter(AlumnoCompuesto alumnoC){
			this.alumnoCompuesto=alumnoC;
		}
		
		public Iterador CrearIterador(){
			Iterador ite=new IteradorAlumnoCompuestoAdapter(this);
			return ite;
		}
		
		public AlumnoCompuesto alumnoComp(){
			return this.alumnoCompuesto;
		}
		
		public int cuantos(){
			return alumnoCompuesto.listaHijos().Count;
		}
		public Comparable minimo(){
			IAlumno minimoActual=this.alumnoCompuesto.listaHijos()[0];
			for (int i = 1; i < this.alumnoCompuesto.listaHijos().Count; i++) {
				if (minimoActual.sosMenor((Comparable)this.alumnoCompuesto.listaHijos()[i])) {
					minimoActual=alumnoCompuesto.listaHijos()[i];
				}
			}
			return (Comparable)minimoActual;
		}
		public Comparable maximo(){
			IAlumno maximoActual=this.alumnoCompuesto.listaHijos()[0];
			for (int i = 1; i > this.alumnoCompuesto.listaHijos().Count; i++) {
				if (maximoActual.sosMenor((Comparable)this.alumnoCompuesto.listaHijos()[i])) {
					maximoActual=alumnoCompuesto.listaHijos()[i];
				}
			}
			return (Comparable)maximoActual;
		}
		public void agregar(Comparable c){
			alumnoCompuesto.agregarAlumno((IAlumno)c);
		}
		
		public bool contiene(Comparable c){
			return alumnoCompuesto.sosIgual(c);
		}
	}
}
