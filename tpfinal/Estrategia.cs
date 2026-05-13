
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
			string resutl = "Implementar";
            return resutl;
		}


		public String Consulta2(List<string> datos)
		{
			string result = "Implementar";
            
            return result;
        }

		

		public String Consulta3(List<string> datos)
		{
			string result = "Implementar";

            return result;
		}


        public void BuscarConOrden(List<string> datos, int cantidad, List<Dato> collected)
        {
            List<Dato> ocurrencias = new List<Dato>();

            foreach (string s in datos)
                {
                    //Separamos del String que viene de datos  el titulo y la descripcion 
                    string[] partes = s.Split('-');
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
            //Implementar
        }




    }
}