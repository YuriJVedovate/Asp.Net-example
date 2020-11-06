using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Example.Models.Request
{
    public class ExampleUpdateRequest
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int NumeroCasa { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
