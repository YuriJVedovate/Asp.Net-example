using Example.Application.Common;
using Example.Application.Vice.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Vice.Models.Response
{
    public class ViceGetAllResponse : BaseResponse
    {
        public ViceGetAllResponse()
        {
            Itens = new List<ViceDto>();
        }

        public List<ViceDto> Itens { get; set; }
    }
}
