 using Example.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Domain.ElectionAggregate
{
    public class ElectionDomain : DomainBase
    {
        public ElectionDomain(string name, string entourage, int age, string occupation, decimal patrimony, string vice)
        {
            this.Name = name;
            this.Entourage = entourage;
            this.Age = age;
            this.Occupation = occupation;
            this.Patrimony = patrimony;
            this.Vice = vice;
        }

        public string Name { get; set; }
        public string Entourage { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public decimal Patrimony { get; set; }
        public string Vice { get; set; }


        public static ElectionDomain Create(string name, string entourage, int age, string occupation, decimal patrimony, string vice) => new ElectionDomain(name, entourage, age, occupation, patrimony, vice);

        public void Update(string name, string entourage, int age, string occupation, decimal patrimony, string vice)
        {
            this.Name = name;
            this.Entourage = entourage;
            this.Age = age;
            this.Occupation = occupation;
            this.Patrimony = patrimony;
            this.Vice = vice;
        }
    }
}
