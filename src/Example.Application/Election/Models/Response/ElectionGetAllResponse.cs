using Example.Application.Common;
using Example.Application.Election.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Election.Models.Response
{
    public class ElectionGetAllResponse : BaseResponse
    {
        public ElectionGetAllResponse()
        {
            Itens = new List<ElectionDto>();
        }

        public List<ElectionDto> Itens { get; set; }
    }
}
