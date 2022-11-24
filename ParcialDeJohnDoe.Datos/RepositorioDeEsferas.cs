using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialDeJohnDoe.Entidades;

namespace ParcialDeJohnDoe.Datos
{
    public class RepositorioDeEsferas
    {
        private List<Esfera> listaEsferas;
        private bool hayCambios = false;

        public RepositorioDeEsferas()
        {
            listaEsferas = new List<Esfera>();
            listaEsferas = ManejadorDeArchivo.LeerDelArchivo();
        }

        public void Agregar(Esfera esfera)
        {
            listaEsferas.Add(esfera);
            hayCambios = true;
        }

        public void Borrar(Esfera esfera)
        {
            listaEsferas.Remove(esfera);
            hayCambios = true;
        }

        public void Editar(Esfera esfera)
        {
            hayCambios = true;
        }

        public List<Esfera> GetLista()
        {
            return listaEsferas;
        }

        public int GetCantidad()
        {
            return listaEsferas.Count;
        }

        public void GuardarEnArchivo()
        {
            if (hayCambios)
            {
                ManejadorDeArchivo.GuardarEnArchivo(listaEsferas);
            }
        }


        public List<Esfera> GetListaOrdenadaAsc()
        {
            return listaEsferas.OrderBy(e => e.Radio).ToList();
        }

        public List<Esfera> GetListaOrdenadaDesc()
        {
            return listaEsferas.OrderByDescending(e => e.Radio).ToList();
        }

        public List<Esfera> FiltrarPorTrazo(Trazo trazoFiltrar)
        {
            return listaEsferas.Where(e => e.Trazo == trazoFiltrar).ToList();
        }
    }
}
