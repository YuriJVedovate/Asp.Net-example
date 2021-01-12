using Example.Domain.PartidoAggregate;
using Example.Domain.SeedWork;
using Example.Domain.ViceAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Domain.CandidatoAggregate
{
    public class CandidatoDomain : DomainBase
    {
        public CandidatoDomain(string nome,  int partidoId, int idade, string posicao, string foto)
        {
            this.Nome = nome;
            this.PartidoId = partidoId;
            this.Idade = idade;
            this.Posicao = posicao;
            this.Foto = foto;
        }

        public string Nome { get; set; }
        public int PartidoId { get; set; }
        public virtual PartidoDomain Partido { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public int ViceId { get; set; }
        public string Foto { get; set; }
        public virtual ViceDomain Vice { get; set; }
        

        public static CandidatoDomain Create(string nome, int partidoId, int idade, string posicao, string foto) => new CandidatoDomain(nome, partidoId, idade, posicao, foto);

        public void Update(string nome, int partidoId, int idade, string posicao, int viceId, string foto)
        {
            this.Nome = nome;
            this.PartidoId = partidoId;
            this.Idade = idade;
            this.Posicao = posicao;
            this.Foto = foto;
            this.ViceId = viceId;
        }

        public void AddVice(string nomeVice, int partidoIdVice, int idadeVice, string foto)
        {
            this.Vice = ViceDomain.Create(nomeVice, partidoIdVice, idadeVice, foto);
        }
    }
}
