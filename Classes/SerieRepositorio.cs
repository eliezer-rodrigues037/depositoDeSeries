using System;
using System.Collections.Generic;
using depositoDeSeries.Series.Interfaces;

namespace depositoDeSeries.Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();

		public SerieRepositorio(){
			populaSeries();
			populaSeries();
			populaSeries();
			populaSeries();
			Console.WriteLine("");
		}
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

		private void populaSeries()
		{
			Serie Serie = new Serie(id: ProximoId(),genero: (Genero)9,titulo: "Rick and Morty",ano: 2013,descricao: "Acompanhe malucas viagens no tempo-espaço e por universos paralelos com Rick, um cientista com problemas com a bebida, e seu neto Morty, um adolescente não tão brilhante quanto o avô");
			Insere(Serie);
			Serie = new Serie(id: ProximoId(),genero: (Genero)2,titulo: "Steven Universo",ano: 2013,descricao: "Quando um cometa mágico vem em direção a Beach City, Steven deverá revirar a coleção de quinquilharias do seu pai para encontrar uma arma capaz de salvar a cidade.");
			Insere(Serie);
			Serie = new Serie(id: ProximoId(),genero: (Genero)5,titulo: "Dark",ano: 2017,descricao: "Os mistérios sombrios de uma pequena cidade alemã são expostos quando duas crianças desaparecem. Enquanto as famílias procuram os dois desaparecidos, eles descobrem uma trama de indivíduos conectados com a história conturbada da cidade.");
			Insere(Serie);
		}
	}
}