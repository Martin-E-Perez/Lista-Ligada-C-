using System;

namespace ListaLigada
{
	class Program
	{
		public static void Main(string[] args)
		{
			//********************************************************			
			CListaLigada myLista = new CListaLigada();
			
			//********************************************************
			myLista.adicionar(5);
			myLista.adicionar(15);
			myLista.adicionar(25);
			myLista.adicionar(35);
			myLista.adicionar(45);
			myLista.adicionar(55);
			
			//********************************************************
			Console.Write("Recorrer Lista: ");
			myLista.recorrerLista();
			
			//********************************************************
			Console.WriteLine();
			Console.WriteLine("La lista esta vacia : {0}",myLista.EstaVacia());
			
			//********************************************************
			Console.WriteLine();
			int Num = 35;
			Console.WriteLine("Buscar {0} --> {1}",Num,myLista.buscar(Num));
			
			//********************************************************
			Console.WriteLine();
			Console.WriteLine("Indice de {0} --> {1}",Num, myLista.buscarIndice(Num));
			
			//********************************************************
			Console.WriteLine();
			Console.WriteLine("{0} Nodo Anterior --> {1}",Num,myLista.buscarAnterior(Num));
			
			//********************************************************
			Console.WriteLine();
			myLista.borrarNodo(25);
			myLista.recorrerLista();
			
			//********************************************************
			Console.WriteLine();
			myLista.insertarAntes(77,55);
			myLista.recorrerLista();
			
			//********************************************************
			Console.WriteLine();
			myLista.insertarDespues(99,55);
			myLista.recorrerLista();
			
			//********************************************************
			Console.WriteLine();
			Console.WriteLine("por indice --> {0}",myLista.buscarPorIndice(3));
			
			//********************************************************
			Console.WriteLine();
			Console.WriteLine("--> {0}",myLista[2]);
			myLista[2] = 369;
			myLista.recorrerLista();
			
			//********************************************************
			Console.WriteLine();
			myLista.vaciar();
			
			//********************************************************
			Console.Write("Recorrer Lista: ");
			myLista.recorrerLista();
			
			//********************************************************
			Console.WriteLine();
			Console.WriteLine("La lista esta vacia : {0}",myLista.EstaVacia());
			
			
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
	}
}