using System;
using System.Collections.Generic;

namespace tpfinal
{
    // Clase Heap basada en lo que vimos en clase
    public class Heap
    {
        private Dato[] datos;
        private int tam;

        // Constructor que recibe los datos y los acomoda
        public Heap(Dato[] inicial)
        {
            this.tam = inicial.Length;
            // El profe dijo que el indice 0 no se usa, asi que el tamaño es tam + 1
            this.datos = new Dato[tam + 1]; 
            
            // Copio los datos al arreglo interno empezando desde la posicion 1
            for (int i = 0; i < tam; i++)
            {
                this.datos[i + 1] = inicial[i];
            }
            
            // Llamo a BuildHeap para que se ordene todo de una vez
            BuildHeap(); 
        }

        // Metodo para armar el heap desde el ultimo padre hacia arriba
        private void BuildHeap()
        {
            // El ultimo padre esta en la posicion tam / 2
            for (int i = tam / 2; i >= 1; i--)
            {
                FiltrarAbajo(i);
            }
        }

        // Saca el dato que tiene mas ocurrencias (la raiz)
        public Dato Eliminar()
        {
            if (tam == 0) return null;
            
            Dato tope = datos[1]; // Guardo la raiz para devolverla
            datos[1] = datos[tam]; // Pongo el ultimo elemento en la raiz
            tam--;
            
            // Si quedan elementos, vuelvo a ordenar bajando el que puse en la raiz
            if (tam > 0) FiltrarAbajo(1);
            
            return tope;
        }

        // Funcion para bajar un elemento a su posicion correcta
        private void FiltrarAbajo(int i)
        {
            while (2 * i <= tam)
            {
                int j = 2 * i; // Hijo izquierdo
                
                // Si el hijo derecho es mas grande que el izquierdo, elijo el derecho
                if (j < tam && Comparar(j + 1, j)) j++;
                
                // Si el padre es mas grande que el hijo elegido, ya esta en su lugar
                if (Comparar(i, j)) break;
                
                // Si no, intercambio y sigo bajando
                Intercambiar(i, j);
                i = j;
            }
        }

        // Compara dos posiciones del arreglo segun las ocurrencias del objeto Dato
        private bool Comparar(int i, int j)
        {
            // Comparamos directamente el numero de ocurrencias
            return datos[i].ocurrencia > datos[j].ocurrencia;
        }

        // Metodo para cambiar de lugar dos elementos
        private void Intercambiar(int i, int j)
        {
            Dato aux = datos[i];
            datos[i] = datos[j];
            datos[j] = aux;
        }

        // Metodo para obtener el camino a la hoja mas izquierda
        public string ObtenerCaminoHojaIzquierda()
        {
            // Si el heap esta vacio no hay camino que recorrer.
            if (tam == 0) return "El Heap esta vacio.";

            // Inicio el camino desde la raiz que esta en la posicion 1.
            string camino = "Raiz (En " + datos[1].texto + " hay " + datos[1].ocurrencia + " ocurrencias)";
            int posicion = 1;

            // Voy siempre al hijo izquierdo hasta que no exista
            while (2 * posicion <= tam)
            {
                // Voy siempre por el hijo izquierdo
                posicion = 2 * posicion;
                camino += " \n <- Izq (En " + datos[posicion].texto + " hay " + datos[posicion].ocurrencia + " ocurrencias)";
            }

            return camino;
        }

        // Metodo para obtener los datos de la heap con sus niveles
        public string ObtenerNivelesHeap()
        {
            // Si el heap esta vacio no hay camino que recorrer.
            if (tam == 0) return "La heap esta vacia";

            string resultado = "";

            for (int i = 1; i <= tam; i++)
                {
                    int nivel = 0;
                    int idx = i;
                    while (idx > 1) { idx >>= 1; nivel++; }

                    if (i == 1)
                        resultado += "En el nivel " + nivel + " " + datos[i].texto + " hay " + datos[i].ocurrencia + " ocurrencias";
                    else
                        resultado += "\nEn el nivel " + nivel + " " + datos[i].texto + " hay " + datos[i].ocurrencia + " ocurrencias";
                }
            return resultado;
        }
    }
}
