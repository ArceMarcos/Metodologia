using System;
using System.Collections.Generic;

namespace Proyecto_7
{
	public class AlumnoCompuesto : IAlumno
	{
		List<IAlumno>hijos;
		public AlumnoCompuesto(){
			this.hijos=new List<IAlumno>();
		}
		
		public List<IAlumno> listaHijos(){
			return this.hijos;
		}
		
		public void agregarAlumno(IAlumno alumno){
			hijos.Add(alumno);
		}
		
		public string getNombre(){
			string nombres="";
			foreach (IAlumno hijo in this.hijos) {
				nombres=nombres+" - "+hijo.getNombre();
			}
			return nombres;
		}
		
		public int getCalificacion(){
			int promedio=0;
			int contador=0;
			foreach (IAlumno hijo in this.hijos) {
				promedio=promedio+hijo.getCalificacion();
				contador++;
			}
			if (contador!=0) {
				return promedio/contador;
			}
			return promedio;
		}
		
		public void setCalificacion(int cali){
			foreach (IAlumno hijo in this.hijos) {
				hijo.setCalificacion(cali);
			}
		}
		
		public void SetEstrategia(EstrategiaComparacionAlumno estra){
			foreach (IAlumno hijo in this.hijos) {
				hijo.SetEstrategia(estra);
			}
		}
		public int getLegajo(){
			int legajo=0;
			foreach (IAlumno hijo in this.hijos) {
				if (legajo<hijo.getLegajo()) {
					legajo=hijo.getLegajo();
				}
			}
			return legajo;
		}
		public int getDni(){
			int dni=99999999;
			foreach (IAlumno hijo in this.hijos) {
				if (dni>hijo.getDni()) {
					dni=hijo.getDni();
				}
			}
			return dni;
		}
		public int getPromedio(){
			int promedio=0;
			int contador=0;
			foreach (IAlumno hijo in this.hijos) {
				promedio=promedio+hijo.getPromedio();
				contador++;
			}
			if (contador!=0) {
				return promedio/contador;
			}
			return promedio;
		}
	 	
	 	public bool sosIgual(Comparable c){
	 		foreach (IAlumno hijo in hijos) {
	 			if (hijo.sosIgual(c)) {
	 				return true;
	 			}
	 		}
	 		return false;
	 	
	 	}
	 	
	 	public bool sosMenor(Comparable c){
	 		foreach (IAlumno hijo in hijos) {
	 			if (hijo.sosMayor(c)) {
	 				return false;
	 			}
	 		}
	 		return true;
	 	}
	 	
	 	public bool sosMayor(Comparable c){
	 		foreach (IAlumno hijo in hijos) {
	 			if (hijo.sosMenor(c)) {
	 				return false;
	 			}
	 		}
	 		return true;
	 	}
	 	
	 	public int responderPregunta(int pregunta){
	 		int voto0=0;
	 		int voto1=0;
	 		int voto2=0;
	 		
	 		foreach (IAlumno hijo in this.hijos) {
	 			int votacion=hijo.responderPregunta(pregunta);
	 			if (votacion==0) {
	 				voto0++;
	 			}
	 			if (votacion==1) {
	 				voto1++;
	 			}
	 			if (votacion==2) {
	 				voto2++;
	 			}
			}
	 		
	 		if (voto0>voto1 && voto0>voto2) {
	 			return voto0;
	 		}
	 		if (voto1>voto2 && voto1>voto0) {
	 			return voto1;
	 		}
	 		if (voto2>voto0 && voto2>voto1) {
	 			return voto2;
	 		}
	 		return Program.Aleatorio(3);
	 	}
	 	public string mostrarCalificacion(){
	 		foreach (IAlumno hijo in hijos) {
	 			hijo.mostrarCalificacion();
	 		}
			return " lista de alumnos vacia ";
	 	}
	}
}
