using Example.Application.Partido.Models.Dtos;
using Example.Application.Vice.Models.Dtos;
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
        public PartidoDto Partido { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public ViceDto Vice { get; set; }


        public static explicit operator CandidatoDto(CandidatoDomain v)
        {
            return new CandidatoDto()
            {
                Id = v.Id,
                Nome = v.Nome,
                Partido = (PartidoDto)v.Partido,
                Idade = v.Idade,
                Posicao = v.Posicao,
                Vice = (ViceDto)v.Vice
            };
        }
    }
}
