/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 25/5/2025
 * Time: 23:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_5
{
	/// <summary>
	/// Description of Ordenable.
	/// </summary>
	public interface Ordenable
	{ 
		void setOrdenInicio(OrdenEnAula1 o);
		void setOrdenLlegaAlumno(OrdenEnAula2 o);
		void setOrdenAulaLlena(OrdenEnAula1 o);	
	}
}
