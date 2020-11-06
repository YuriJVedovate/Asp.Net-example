using Example.Domain.ExampleAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Example.Models.Dtos
{
    public class ExampleDto
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public int NumeroCasa { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }



        public static explicit operator ExampleDto(ExampleDomain v)
        {
            return new ExampleDto()
            {
                Id = v.Id,
                Age = v.Age,
                Name = v.Name,
                NumeroCasa = v.NumeroCasa,
                Rua = v.Rua,
                Cidade = v.Cidade,
                Estado = v.Estado,
            };
        }
    }
}
