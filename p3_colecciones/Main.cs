using System;
using System.Collections;

namespace p3_colecciones
{
	class MainClass
	{
		public void ejemploArreglos(){
			int[] arreglo = new int[] {1,2,3,4,5};
			
			foreach(int numero in arreglo){
				Console.WriteLine(numero);
			}
			
			arreglo[0] = 0;
			arreglo[1] = 1;
			arreglo[2] = 2;
			arreglo[3] = 3;
			arreglo[4] = 4;
			
			for(int i=0;i < arreglo.Length; i++){
				int numero = arreglo[i];
				Console.WriteLine(numero);
			}
		}
		
		public static void Main (string[] args)
		{
			//MainClass principal = new MainClass();
			//principal.ejemploArreglos();

			//ejemploArrayList arraylist = new ejemploArrayList();
			//arraylist.mostrar();
			
			//ejemploPila pila = new ejemploPila();
			//pila.mostrar();

			//ejemploCola cola = new ejemploCola();
			//cola.mostrar();

			ejemploHashTable hashtable = new ejemploHashTable();
			hashtable.mostrar();
		}

	}
}
