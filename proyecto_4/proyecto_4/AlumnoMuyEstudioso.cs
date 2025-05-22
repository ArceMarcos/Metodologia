/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 25/4/2025
 * Time: 06:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_4
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso : Alumno
	{
		public AlumnoMuyEstudioso(string nombre,int dni,int legajo,double promedio):base( nombre, dni, legajo, promedio){
			this.nombre=nombre;
			this.dni=dni;
			this.legajo=legajo;
			this.promedio=promedio;
			this.estrategia=new ComparaAlumnoPromedio();
		}
		
		public override int responderPregunta(int pregunta){
			return pregunta%3;	
		}

	}
}
