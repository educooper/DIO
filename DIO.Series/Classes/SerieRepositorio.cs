using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series

{
    public class SerieRepositorio : iRepositorio<Serie>
    {
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto; 
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie[id].add(objeto);
        }

        public List<Serie> lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
