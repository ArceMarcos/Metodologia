/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 25/5/2025
 * Time: 22:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_7
{
	/// <summary>
	/// Description of OrdenAulaLlena.
	/// </summary>
	public class OrdenAulaLlena : OrdenEnAula1
	{
		private Aula aula;
		
		public OrdenAulaLlena(Aula au){
			this.aula=au;
		}
		
		public void ejecutar(){
			aula.claseLista();
		}
	}
}
