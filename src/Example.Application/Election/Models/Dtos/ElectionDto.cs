using Example.Domain.ElectionAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Application.Election.Models.Dtos
{
    public class ElectionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Entourage { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public decimal Patrimony { get; set; }
        public string Vice { get; set; }

        public static explicit operator ElectionDto(ElectionDomain v)
        {
            return new ElectionDto()
            {
                Id = v.Id,
                Name = v.Name,
                Entourage = v.Entourage,
                Age = v.Age,
                Occupation = v.Occupation,
                Patrimony = v.Patrimony,
                Vice = v.Vice
            };
        }
    }
}
