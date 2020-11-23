using Example.Domain.ViceAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Vice.Models.Dtos
{
    public class ViceDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PartidoId { get; set; }
        public string NomePartido { get; set; }
        public int NumeroEleitoral { get; set; }
        public int Idade { get; set; }

        public static explicit operator ViceDto(ViceDomain v)
        {
            return new ViceDto()
            {
                Id = v.Id,
                Nome = v.Nome,
                PartidoId = v.PartidoId,
                NomePartido = v.Partido.Nome,
                NumeroEleitoral = v.Partido.NumeroEleitoral,
                Idade = v.Idade

            };
        }
    }

}
