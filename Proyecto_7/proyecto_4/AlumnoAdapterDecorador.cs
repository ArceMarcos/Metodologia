/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 21/5/2025
 * Time: 22:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_7
{
	/// <summary>
	/// Description of StudentDecorador.
	/// </summary>
	public abstract class AlumnoAdapterDecorador : IAlumnoAdapterDecorado
	{
		IAlumnoAdapterDecorado adicional;
		
		public AlumnoAdapterDecorador(IAlumnoAdapterDecorado a){
			this.adicional=a;
		}
		
		public virtual string showResult(){
			return adicional.showResult();
		}
	}
}
