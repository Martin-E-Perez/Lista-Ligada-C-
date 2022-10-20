using System;

namespace ListaLigada
{
	public class CListaLigada
	{
		
		public CNodo encabezado;
		
		public CListaLigada()
		{
			encabezado = new CNodo();
		}
		
		public CListaLigada(int dato)
		{
			encabezado = new CNodo();
			encabezado.datoNodo = dato;
		}
			
		
		public void adicionar(int dato)
		{
			CNodo auxiliar = encabezado;
			
			while (auxiliar.nodoSiguiente!=null) {
				
				auxiliar = auxiliar.nodoSiguiente;
				
			}
			
			CNodo auxiliar2 = new CNodo();
			
			auxiliar2.datoNodo = dato;
			
			auxiliar.nodoSiguiente = auxiliar2;
			
		}
		
		public void recorrerLista()
		{
			CNodo auxiliar = encabezado;
			
			while (auxiliar.nodoSiguiente!=null) {
					
				auxiliar = auxiliar.nodoSiguiente;
				
				Console.Write("{0}-->",auxiliar.datoNodo);
			}
			
			Console.Write("Null");
			Console.WriteLine();
		}
		
		
		public bool EstaVacia()
		{
			if (encabezado.nodoSiguiente == null) {
				return true;
			}
			
			return false;
		}
		
		public CNodo buscar(int datoConsultado)
		{
			
			if (EstaVacia()==true) {
				return null;
			}
			
			bool fin = false;
			CNodo auxiliar = encabezado;
			
			while (fin == false) {
				
				if (auxiliar.datoNodo == datoConsultado) {
					return auxiliar;
				}
				
				if (auxiliar.nodoSiguiente==null) {
					fin = true;
				}
				
				auxiliar = auxiliar.nodoSiguiente;
				
			}
			
			return null;
		}
		
		
		public void vaciar()
		{
			encabezado.nodoSiguiente=null;
		}
		
			
		public int buscarIndice(int datoConsultado)
		{
			int indice=-1;
			int indiceAux=-1;
			
			if (EstaVacia()==true) {
				return indice;
			}
			
			CNodo auxiliar = encabezado;
			
			  while (indice==indiceAux) {
				
				if (auxiliar.datoNodo == datoConsultado) {
					return indice;
				}
				
				if (auxiliar.nodoSiguiente!=null) {
					indiceAux++;
				}
				indice++;
					
				auxiliar = auxiliar.nodoSiguiente;
				
			}
			
			return -1;
		}
		
		public CNodo buscarAnterior(int datoConsultado)
		{
			
			if (EstaVacia()==true) {
				return null;
			}
			
			bool fin = false;
			CNodo auxiliar = encabezado;
			CNodo auxiliar2 = null;
			
			while (fin == false) {
				
				if (auxiliar.datoNodo == datoConsultado) {
					return auxiliar2;
				}
				
				if (auxiliar.nodoSiguiente==null) {
					fin = true;
				}
					
				auxiliar2 = auxiliar;
				auxiliar = auxiliar.nodoSiguiente;
				
			}
			
			return null;
		}
		
		public void borrarNodo (int datoConsultado)
		{
			CNodo NodoAnt = buscarAnterior(datoConsultado);
			CNodo Nodo = NodoAnt.nodoSiguiente;
			
			NodoAnt.nodoSiguiente = Nodo.nodoSiguiente;
			Nodo.nodoSiguiente = null;
			
		}
		
		public void insertarAntes (int dato, int DatoNodoRefer)
		{
			CNodo NodoAnt = buscarAnterior(DatoNodoRefer);
			CNodo NodoRef = NodoAnt.nodoSiguiente;
			
			CNodo NuevoNodo = new CNodo();
			NuevoNodo.datoNodo = dato;
			
			NodoAnt.nodoSiguiente = NuevoNodo;
			NuevoNodo.nodoSiguiente = NodoRef;
			
		}
		
		public void insertarDespues (int dato, int DatoNodoRefer)
		{
			CNodo NodoRef = buscar(DatoNodoRefer);
			CNodo NodoSig = NodoRef.nodoSiguiente;
			
			CNodo NuevoNodo = new CNodo();
			NuevoNodo.datoNodo = dato;
			
			NodoRef.nodoSiguiente = NuevoNodo;
			NuevoNodo.nodoSiguiente = NodoSig;
			
		}
		
		public CNodo buscarPorIndice (int dato)
		{
			
			if (EstaVacia()==true) {
				return null;
			}
			
			bool fin = false;
			CNodo auxiliar = encabezado;
			int contador = -1;
			
			while (fin == false) {
				
				if (contador == dato) {
					return auxiliar;
				}
				
				if (auxiliar.nodoSiguiente==null ) {
					fin = true;
				}
				
				auxiliar = auxiliar.nodoSiguiente;
				
				contador++;
				
			}
			
			return null;
			
		}
		
		public int this[int dato]
		{
			get 
			{
				CNodo auxiliar = buscarPorIndice(dato);
				return auxiliar.datoNodo;
			}
			
			set
			{
				CNodo auxiliar = buscarPorIndice(dato);
				if (auxiliar!=null)
				{
					auxiliar.datoNodo = value;
				}
			}
			
		}
		
		
	}
}
