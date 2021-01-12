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
        public PartidoDomain(string nome, string sigla, int numeroEleitoral, string foto)
        {
            this.Nome = nome;
            this.Sigla = sigla;
            this.NumeroEleitoral = numeroEleitoral;
            this.Foto = foto;
        }


        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int NumeroEleitoral { get; set; }
        public string Foto { get; set; }
        public virtual ICollection<CandidatoDomain> Candidatos { get; set; }
        public virtual ICollection<ViceDomain> Vices { get; set; }





        public static PartidoDomain Create(string nome, string sigla, int numeroEleitoral, string foto) => new PartidoDomain(nome, sigla, numeroEleitoral, foto);

        public void Update(string nome, string sigla, int numeroEleitoral, string foto)
        {
            this.Nome = nome;
            this.Sigla = sigla;
            this.NumeroEleitoral = numeroEleitoral;
            this.Foto = foto;

        }

    }
}
