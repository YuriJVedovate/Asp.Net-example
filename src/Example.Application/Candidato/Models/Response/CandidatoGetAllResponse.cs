using Example.Application.Common;
using Example.Application.Candidato.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Candidato.Models.Response
{
    public class CandidatoGetAllResponse : BaseResponse
    {
        public CandidatoGetAllResponse()
        {
            Itens = new List<CandidatoDto>();
        }

        public List<CandidatoDto> Itens { get; set; }
    }
}
