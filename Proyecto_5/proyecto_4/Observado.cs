using System;

namespace Proyecto_5
{
	/// <summary>
	/// Description of Observado.
	/// </summary>
	public interface Observado
	{
		void agregarObservador(Observador o);
		void quitar(Observador o);
		void notificar();
	}
}
