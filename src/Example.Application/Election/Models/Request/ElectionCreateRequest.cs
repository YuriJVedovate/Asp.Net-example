using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Election.Models.Request
{
    public class ElectionCreateRequest
    {
        public string Name { get; set; }
        public string Entourage { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public decimal Patrimony { get; set; }
        public string Vice { get; set; }
    }
}
