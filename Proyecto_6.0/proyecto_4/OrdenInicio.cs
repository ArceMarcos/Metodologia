/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 25/5/2025
 * Time: 22:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_60
{
	/// <summary>
	/// Description of OrdenInicio.
	/// </summary>
	public class OrdenInicio : OrdenEnAula1
	{
		private Aula aula;
		
		public OrdenInicio(Aula au){
			this.aula=au;
		}
		
		public void ejecutar(){
			aula.comenzar();
		}
	}
}
