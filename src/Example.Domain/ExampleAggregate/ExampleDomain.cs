using Abp.Domain.Entities;
using Example.Domain.SeedWork;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Text;

namespace Example.Domain.ExampleAggregate
{
    public class ExampleDomain : DomainBase
    {
        public ExampleDomain(int? age, string name, int? numeroCasa, string rua, string cidade, string estado)
        {
            this.Age = age;
            this.Name = name;
            this.NumeroCasa = numeroCasa;
            this.Rua = rua;
            this.Cidade = cidade;
            this.Estado = estado;

        }

        public int? Age { get; set; }
        public string Name { get; set; }
        public int? NumeroCasa { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        public static ExampleDomain Create(int? age, string name, int? numeroCasa, string rua, string cidade, string estado) => new ExampleDomain(age, name, numeroCasa, rua, cidade, estado);

        public void Update(int age, string name, int numeroCasa, string rua, string cidade, string estado)
        {
            this.Age = age;
            this.Name = name;
            this.NumeroCasa = numeroCasa;
            this.Rua = rua;
            this.Cidade = cidade;
            this.Estado = estado;
        }
    }
}
