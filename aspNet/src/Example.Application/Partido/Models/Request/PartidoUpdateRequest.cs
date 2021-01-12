using Example.Application.Partido.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Partido.Models.Request
{
    public class PartidoUpdateRequest
    {
        public string NamePartido { get; set; }
        public string SiglaPartido { get; set; }
        public int NumeroEleitoral { get; set; }
        public string Foto { get; set; }
    }
}
