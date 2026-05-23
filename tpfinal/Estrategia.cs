
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Windows.Forms;
using tp1;

namespace tpfinal
{

	public class Estrategia
	{
	
		public String Consulta1(List<string> datos)
		{
			string resutl = "";
            List<Dato> heapResultado = new List<Dato>();
            List<Dato> ordenResultado = new List<Dato>();

            // Stopwatch crea un cronometro para medir el tiempo de ejecución de cada metodo.
            // con StartNew() se inicia el cronometro automaticamente.
            Stopwatch swHeap = Stopwatch.StartNew();
            BuscarConHeap(datos, 5, heapResultado);
            // con Stop() se detiene el cronometro.
            swHeap.Stop();

            Stopwatch swOrden = Stopwatch.StartNew();
            BuscarConOrden(datos, 5, ordenResultado);
            swOrden.Stop();
            // Con ElapsedMilliseconds se obtiene el tiempo transcurrido en milisegundos.
            resutl = "BuscarConHeap: " + swHeap.ElapsedMilliseconds + " ms \nBuscarConOrden: " + swOrden.ElapsedMilliseconds + " ms";

            return resutl;
		}


		public String Consulta2(List<string> datos)
		{
			// Uso un Diccionario para contar cuantas veces aparece cada texto.
            Dictionary<string, int> contadorOcurrencias = new Dictionary<string, int>();
            foreach (string s in datos)
            {
                if (contadorOcurrencias.ContainsKey(s)) contadorOcurrencias[s]++;
                else contadorOcurrencias[s] = 1;
            }

            // Paso los resultados del conteo a una lista de objetos tipo Dato.
            List<Dato> listaD = new List<Dato>();
            foreach (var aux in contadorOcurrencias)
            {
                listaD.Add(new Dato(aux.Value, aux.Key));
            }

            // Creo el Heap pasandole la lista como un arreglo.
            Heap heapDatos = new Heap(listaD.ToArray());

            // Obtengo el camino a la hoja más izquierda.
            string result = heapDatos.ObtenerCaminoHojaIzquierda();

            return result;
        }

		

		public String Consulta3(List<string> datos)
		{
			// Uso un Diccionario para contar cuantas veces aparece cada texto
            Dictionary<string, int> contadorOcurrencias = new Dictionary<string, int>();
            foreach (string s in datos)
            {
                if (contadorOcurrencias.ContainsKey(s)) contadorOcurrencias[s]++;
                else contadorOcurrencias[s] = 1;
            }

            // Paso los resultados del conteo a una lista de objetos tipo Dato
            List<Dato> listaD = new List<Dato>();
            foreach (var aux in contadorOcurrencias)
            {
                listaD.Add(new Dato(aux.Value, aux.Key));
            }

            // Creo el Heap pasandole la lista como un arreglo
            Heap heapDatos = new Heap(listaD.ToArray());

            // Obtengo los datos de la heap con sus niveles
            string result = heapDatos.ObtenerNivelesHeap();

            return result;
		}


        public void BuscarConOrden(List<string> datos, int cantidad, List<Dato> collected)
        {
            List<Dato> ocurrencias = new List<Dato>();

            foreach (string s in datos)
                {
                    //Separamos del String que viene de datos  el titulo y la descripcion 
                    string[] partes = s.Split(';');
                    string titulo = partes[0];
                    string descripcion = partes.Length > 1 ? partes[1] : "";

                    
                    bool encontrado = false;
                    for (int i = 0; i < ocurrencias.Count; i++)
                    {
                        if (ocurrencias[i].texto == titulo)
                        {
                            ocurrencias[i].ocurrencia++;
                            encontrado = true;
                            break;
                        }
                    }

                    
                    if (!encontrado)
                    {
                        ocurrencias.Add(new Dato(1, titulo, descripcion));
                    }
                }

                QuickSort.Ordenar(ocurrencias);

                for (int i = 0; i < cantidad && i < ocurrencias.Count; i++)
                    {
                    collected.Add(ocurrencias[i]);
                    }
        }
        

                
        


        public void BuscarConHeap(List<string> datos, int cantidad, List<Dato> collected)
        {
            // Uso un Diccionario para contar cuantas veces aparece cada texto
            Dictionary<string, int> contador = new Dictionary<string, int>();
            foreach (string s in datos)
            {
                if (contador.ContainsKey(s)) contador[s]++; // Si ya la conocía, le sumo 1 al contador
                else contador[s] = 1; // Si es la primera vez que la veo, la anoto con un 1
            }

            // Paso los resultados del conteo a una lista de objetos tipo Dato
            List<Dato> listaD = new List<Dato>();
            foreach (var aux in contador)
            {
                // El constructor de Dato recibe: ocurrencias y el texto
                listaD.Add(new Dato(aux.Value, aux.Key));
            }

            // Creo el Heap pasandole la lista como un arreglo
            // El constructor del Heap ya se encarga de ordenarlo solo
            Heap miHeap = new Heap(listaD.ToArray());

            // Saco del Heap la cantidad de mejores elementos que me pidieron
            for (int i = 0; i < cantidad; i++)
            {
                Dato max = miHeap.Eliminar();
                if (max != null)
                {
                    collected.Add(max); // Lo agrego a la lista que ve el usuario
                }
            }
        }
    }
}
