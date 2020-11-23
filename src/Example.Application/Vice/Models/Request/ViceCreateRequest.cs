using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Vice.Models.Request
{
    public class ViceCreateRequest
    {
        public string Nome { get; set; }
        public int PartidoId { get; set; }
        public int Idade { get; set; }

    }
}
