using Example.Application.Candidato.Models.Dtos;
using Example.Application.Partido.Models.Dtos;
using Example.Domain.CandidatoAggregate;
using Example.Domain.PartidoAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Partido.Models.Dtos
{
    public class PartidoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int NumeroEleitoral { get; set; }
        public string Foto { get; set; }


        public static explicit operator PartidoDto(PartidoDomain v)
        {
            return new PartidoDto()
            {
                Id = v.Id,
                Nome = v.Nome,
                Sigla = v.Sigla,
                NumeroEleitoral = v.NumeroEleitoral,
                Foto = v.Foto
            };
        }
    }
}
