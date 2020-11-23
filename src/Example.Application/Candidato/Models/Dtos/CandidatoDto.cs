using Example.Application.Partido.Models.Dtos;
using Example.Domain.CandidatoAggregate;
using Example.Domain.PartidoAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Candidato.Models.Dtos
{
    public class CandidatoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomePartido { get; set; }
        public string CiglaPartido { get; set; }
        public int NumeroPartido { get; set; }

        //public PartidoDto Partido { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public int ViceId { get; set; }
        public string ViceNome { get; set; }
        public string VicePartido { get; set; }


        public static explicit operator CandidatoDto(CandidatoDomain v)
        {
            return new CandidatoDto()
            {
                Id = v.Id,
                Nome = v.Nome,
                NomePartido = v.Partido.Nome,
                CiglaPartido = v.Partido.Cigla,
                NumeroPartido = v.Partido.NumeroEleitoral,
                Idade = v.Idade,
                Posicao = v.Posicao,
                ViceId = v.Vice.Id,
                ViceNome = v.Vice.Nome,
                VicePartido = v.Vice.Partido.Cigla
            };
        }
    }
}
