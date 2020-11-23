using Example.Domain.CandidatoAggregate;
using Example.Domain.SeedWork;
using Example.Domain.ViceAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Domain.PartidoAggregate
{
    public class PartidoDomain : DomainBase
    {
        public PartidoDomain(string nome, string cigla, int numeroEleitoral)
        {
            this.Nome = nome;
            this.Cigla = cigla;
            this.NumeroEleitoral = numeroEleitoral;
        }


        public string Nome { get; set; }
        public string Cigla { get; set; }
        public int NumeroEleitoral { get; set; }
        public virtual ICollection<CandidatoDomain> Candidatos { get; set; }
        public virtual ICollection<ViceDomain> Vices { get; set; }





        public static PartidoDomain Create(string nome, string cigla, int numeroEleitoral) => new PartidoDomain(nome, cigla, numeroEleitoral);

        public void Update(string nome, string cigla, int numeroEleitoral)
        {
            this.Nome = nome;
            this.Cigla = cigla;
            this.NumeroEleitoral = numeroEleitoral;
        }

    }
}
