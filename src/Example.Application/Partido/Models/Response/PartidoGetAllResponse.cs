using Example.Application.Common;
using Example.Application.Partido.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Partido.Models.Response
{
    public class PartidoGetAllResponse : BaseResponse
    {
        public PartidoGetAllResponse()
        {
            Itens = new List<PartidoDto>();
        }

        public List<PartidoDto> Itens { get; set; }
    }
}
