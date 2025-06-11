/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 4/6/2025
 * Time: 07:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Proyecto_7
{
	/// <summary>
	/// Description of IteradorAlumnoCompuestoAdapter.
	/// </summary>
	public class IteradorAlumnoCompuestoAdapter : Iterador
	{
		private AlumnoCompuestoAdapter a;
		private int indice;
		
		public IteradorAlumnoCompuestoAdapter(AlumnoCompuestoAdapter c){
			this.a=c;
			primero();
		}
		
		public void primero(){
			this.indice=0;
		}
		
		public void siguiente(){
			this.indice++;
		}
		
		public bool fin(){
			return this.indice==this.a.alumnoComp().listaHijos().Count;
		}
		
		public Comparable actual(){
			return (Comparable)a.alumnoComp().listaHijos()[(int)indice];
		}
	}
}
