/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 15/4/2025
 * Time: 06:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_3
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new Profesor(gen.stringAleatorio(),gen.NumeroAleatorio(50000000),gen.NumeroAleatorio(30));
		}
		
		public override Comparable crearPorTeclado(){
			return new Profesor(lec.stringPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado());
		}
	}
}