using System;
using System.Collections;

namespace p3_colecciones
{
	public class ejemploArrayList
	{
		public ejemploArrayList ()
		{
		}
		
		public void mostrar(){
			ArrayList myArrayList = new ArrayList();
	      	myArrayList.Add("Hola");
	      	myArrayList.Add("Mundo");
	      	myArrayList.Add("!");
			
			myArrayList.Remove("!");
			myArrayList.RemoveAt(1);
	
	      	Console.WriteLine( "Ejemplo de ArrayList" );
	      	Console.WriteLine( "    Count:    {0}", myArrayList.Count );
	      	Console.Write( "    Values:" );
	      	PrintValues( myArrayList );
			Console.WriteLine();

			Persona juan = new Persona();
			juan.nombre = "Juan";
			
			Persona mariana = new Persona();
			mariana.nombre = "Mariana";
		
			ArrayList personas = new ArrayList();
			personas.Add(juan);
			personas.Add(mariana);
			personas.Add("Mensaje");
			personas.Add(102);
			PrintValues(personas);
			
			Persona desconocido = new Persona();
			desconocido.nombre = "Desconocido";
			
			personas.Insert(2,desconocido);
			PrintValues(personas);

			
			try{				 //Persona	//Objeto
				object objeto = personas[4];
				Persona persona = (Persona) objeto;
				Console.WriteLine("Persona es " + persona.nombre);
			}catch(Exception e){
				Console.WriteLine("Ocurrio un error");
			}
		}
		
		private static void PrintValues( IEnumerable myList )  {
      		foreach ( Object obj in myList ){
         		Console.Write( "    {0}", obj );
			}
      		Console.WriteLine();
   		}
	}
}

