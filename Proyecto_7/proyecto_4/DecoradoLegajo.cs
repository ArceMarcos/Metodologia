/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 21/5/2025
 * Time: 22:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_7
{
	/// <summary>
	/// Description of DecoradoLegajo.
	/// </summary>
	public class DecoradoLegajo : AlumnoAdapterDecorador
	{
		AlumnoAdapter alumnoadapter;
		
		public DecoradoLegajo(AlumnoAdapter ala, IAlumnoAdapterDecorado iaa):base(iaa){
			this.alumnoadapter=ala;
		}
		
		public override string showResult(){
			
			return base.showResult()+"   "+alumnoadapter.getAlumno().getLegajo();
		}
			
	}
}
