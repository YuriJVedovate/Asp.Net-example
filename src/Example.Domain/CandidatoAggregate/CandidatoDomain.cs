using Example.Domain.PartidoAggregate;
using Example.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Domain.CandidatoAggregate
{
    public class CandidatoDomain : DomainBase
    {
        public CandidatoDomain(string nome,  int partidoId, int idade, string posicao, string vice)
        {
            this.Nome = nome;
            this.PartidoId = partidoId;
            this.Idade = idade;
            this.Posicao = posicao;
            this.Vice = vice;
        }

        public string Nome { get; set; }
        public int PartidoId { get; set; }
        public virtual PartidoDomain Partido { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public string Vice { get; set; }


        public static CandidatoDomain Create(string nome, int partidoId, int idade, string posicao, string vice) => new CandidatoDomain(nome, partidoId, idade, posicao, vice);

        public void Update(string nome, int partidoId, int idade, string posicao, string vice)
        {
            this.Nome = nome;
            this.PartidoId = partidoId;
            this.Idade = idade;
            this.Posicao = posicao;
            this.Vice = vice;
        }
    }
}
