using Example.Application.Common;
using Example.Application.Vice.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Vice.Models.Response
{
    public class ViceGetOneResponse : BaseResponse
    {
        public ViceDto Vice { get; set; }
    }
}
