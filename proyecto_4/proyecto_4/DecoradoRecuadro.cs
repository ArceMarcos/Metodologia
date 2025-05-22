
using System;

namespace Proyecto_4
{
	public class DecoradoRecuadro : AlumnoAdapterDecorador
	{
		
		AlumnoAdapter alumnoAdapter;
		
		public DecoradoRecuadro(AlumnoAdapter ala, IAlumnoAdapterDecorado iaa):base(iaa){
			this.alumnoAdapter=ala;
		}
		
		public string contadorDeEspacio(){
			string aux=base.showResult();
			string espacios="";
			int contador=50;
			foreach (var letra in aux) {
				contador--;
			}
			for (int i = 0; i < contador; i++) {
				espacios=espacios+" ";
			}
			return espacios;
		}
		
		public override string showResult(){
			return "****************************************************\n*"+base.showResult()+contadorDeEspacio()+"*\n****************************************************";
		}
	}
}
