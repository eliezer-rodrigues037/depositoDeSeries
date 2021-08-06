using System;

namespace depositoDeSeries.Series
{
    public class Filme : EntidadeBase
    {
        private Genero Genero { get; set; }
		private string Titulo { get; set; }
        private string Diretor {get; set;}
		private string Sinopse
         { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}

        public Filme(int id, Genero genero, string titulo, string diretor, string sinopse, int ano )
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Diretor = diretor;
            this.Sinopse= sinopse;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero +  Environment.NewLine;
            retorno += "Título: " + this.Titulo +  Environment.NewLine;
            retorno += "Diretor: " + this.Diretor + Environment.NewLine;
            retorno += "Sinopse: " + this.Sinopse + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += this.Excluido? "*Excluido" : "";
            return retorno;
        }
    }
}