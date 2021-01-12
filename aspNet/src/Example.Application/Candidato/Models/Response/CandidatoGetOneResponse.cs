using Example.Application.Common;
using Example.Application.Candidato.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Candidato.Models.Response
{
    public class CandidatoGetOneResponse : BaseResponse
    {
        public CandidatoDto Candidato { get; set; }
    }
}
