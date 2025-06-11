using System;

namespace Proyecto_60
{

	public class DecoradoPromocion : AlumnoAdapterDecorador
	{
		AlumnoAdapter alumnoAdapter;
				
		public DecoradoPromocion(AlumnoAdapter ala, IAlumnoAdapterDecorado iaa):base(iaa){
			this.alumnoAdapter=ala;
		}
		
		public string Promocion(){
			if (alumnoAdapter.getAlumno().getCalificacion()>=7) {
				return " PROMOCION ";
			}
			if (alumnoAdapter.getAlumno().getCalificacion()<7&&alumnoAdapter.getAlumno().getCalificacion()>=4) {
				return " APROBADO ";
			}else{
				return "DESAPROBADO";
			}
		}
				
		public override string showResult(){
			return base.showResult()+"     "+Promocion();
		}
	}
}
