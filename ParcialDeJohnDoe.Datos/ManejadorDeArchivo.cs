using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialDeJohnDoe.Entidades;

namespace ParcialDeJohnDoe.Datos
{
    public static class ManejadorDeArchivo
    {
        private static string archivo = "Esferas.text";

        public static void GuardarEnArchivo(List<Esfera> lista)
        {
            using (var escritor=new StreamWriter(archivo))
            {
                foreach (var esfera in lista)
                {
                    string linea = ConstuirLinea(esfera);
                    escritor.WriteLine(linea);
                }
            }
        }

        private static string ConstuirLinea(Esfera esfera)
        {
            return $"{esfera.Radio}|{(int)esfera.Relleno}|{(int)esfera.Trazo}";
        }

        public static List<Esfera> LeerDelArchivo()
        {
            List<Esfera> lista = new List<Esfera>();
            using (var lector=new StreamReader(archivo))
            {
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine();
                    Esfera esfera = CrearEsfera(linea);
                    lista.Add(esfera);
                }
            }

            return lista;
        }

        private static Esfera CrearEsfera(string linea)
        {
            var campos = linea.Split('|');
            Esfera esfera = new Esfera()
            {
                Radio = int.Parse(campos[0]),
                Relleno = (Relleno)int.Parse(campos[1]),
                Trazo = (Trazo)int.Parse(campos[2])
            };
            return esfera;
        }
    }
}
