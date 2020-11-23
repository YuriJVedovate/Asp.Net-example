using Example.Domain.CandidatoAggregate;
using Example.Domain.PartidoAggregate;
using Example.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Domain.ViceAggregate
{
    public class ViceDomain : DomainBase
    {
        public ViceDomain(string nome, int partidoId, int idade)
        {
            this.Nome = nome;
            this.PartidoId = partidoId;
            this.Idade = idade;
        }

        public string Nome { get; set; }
        public int PartidoId { get; set; }
        public virtual PartidoDomain Partido { get; set; }
        public int Idade { get; set; }
        public virtual CandidatoDomain Prefeito { get; set; }


        public static ViceDomain Create(string nome, int partidoId, int idade) => new ViceDomain(nome, partidoId, idade);

        public void Update(string nome, int partidoId, int idade)
        {
            this.Nome = nome;
            this.PartidoId = partidoId;
            this.Idade = idade;
        }
    }
}
