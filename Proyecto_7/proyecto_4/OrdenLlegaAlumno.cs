/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 25/5/2025
 * Time: 23:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_7
{
	/// <summary>
	/// Description of OrdenLlegaAlumno.
	/// </summary>
	public class OrdenLlegaAlumno : OrdenEnAula2
	{
		private Aula aula;
		
		public OrdenLlegaAlumno(Aula au){
			this.aula=au;
		}
		
		public void ejecutar(Comparable com){
			this.aula.nuevoAlumno((IAlumno)com);
		}
	}
}
