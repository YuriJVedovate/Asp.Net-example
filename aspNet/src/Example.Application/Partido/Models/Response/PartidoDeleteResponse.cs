using Example.Application.Common;
using Example.Application.Partido.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Partido.Models.Response
{
    public class PartidoDeleteResponse : BaseResponse
    {
        public PartidoDto Partido { get; set; }
    }
}
