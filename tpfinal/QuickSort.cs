using System;
using System.Collections.Generic;

namespace tpfinal
{
    public class QuickSort
    {
        public static void Ordenar(List<Dato> lista)
        {
            if (lista == null || lista.Count <= 1) return;
            QuickSortRecursivo(lista, 0, lista.Count - 1);
        }

        private static void QuickSortRecursivo(List<Dato> lista, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int pivote = Particionar(lista, inicio, fin);
                QuickSortRecursivo(lista, inicio, pivote - 1);
                QuickSortRecursivo(lista, pivote + 1, fin);
            }
        }

        private static int Particionar(List<Dato> lista, int inicio, int fin)
        {
            int ocurrenciaPivote = lista[fin].ocurrencia;
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (lista[j].ocurrencia >= ocurrenciaPivote)
                {
                    i++;
                    Dato temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }

            Dato temp2 = lista[i + 1];
            lista[i + 1] = lista[fin];
            lista[fin] = temp2;
            return i + 1;
        }
    }
}
