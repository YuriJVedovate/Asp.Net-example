using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Vice.Models.Request
{
    public class ViceUpdateRequest
    {
        public string Nome { get; set; }
        public int PartidoId { get; set; }
        public int Idade { get; set; }
        public int PrefeitoId { get; set; }
        public string Foto { get; set; }
    }
}
