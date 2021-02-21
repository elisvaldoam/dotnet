using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dio.series;
using dio.series.Interfaces;

    class SerieRepositorio : IRepositorio<Serie>
    {
		private List<Serie> listaSerie = new List<Serie>();
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
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
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

    void IRepositorio<Serie>.Insere(Task entidade)
    {
        throw new NotImplementedException();
    }
}

