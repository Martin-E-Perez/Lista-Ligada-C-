using System;

namespace ListaLigada
{
	public class CNodo
	{
		public int datoNodo;
		
		public CNodo nodoSiguiente;
		
		public CNodo()
		{
			nodoSiguiente = null;
		}
		
		public override string ToString()
		{
			return string.Format("[{0}]", datoNodo);
		}

	}
}
