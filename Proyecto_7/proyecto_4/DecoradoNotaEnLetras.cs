/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 21/5/2025
 * Time: 22:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Proyecto_7
{
	/// <summary>
	/// Description of DecoradoNotaEnLetras.
	/// </summary>
	public class DecoradoNotaEnLetras: AlumnoAdapterDecorador
	{
		List<string> notasEnLetras;
		
		AlumnoAdapter alumnoAdapter;
		public DecoradoNotaEnLetras(AlumnoAdapter ala, IAlumnoAdapterDecorado iaa):base(iaa){
			this.alumnoAdapter=ala;
			notasEnLetras=new List<string>(){"(Cero)","(Uno)","(Dos)","(Tres)","(Cuatro)","(Cinco)","(Seis)","(Siete)","(Ocho)","(Nueve)","(Diez)"};
		}
		
		
		
		public override string showResult(){
			return base.showResult()+"     "+notasEnLetras[(int)alumnoAdapter.getAlumno().getCalificacion()];
		}
	}
}
