using Example.Application.Common;
using Example.Application.Election.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Election.Models.Response
{
    public class ElectionDeleteResponse : BaseResponse
    {
        public ElectionDto Election { get; set; }
    }
}
