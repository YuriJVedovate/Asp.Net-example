using Example.Application.Partido.Models.Dtos;
using Example.Application.Vice.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Candidato.Models.Request
{
    public class CandidatoUpdateRequest
    {
        public string Nome { get; set; }
        public int PartidoId { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public string Foto { get; set; }
        public int ViceId { get; set; }
        //public ViceDto Vice { get; set; }
    }
}
