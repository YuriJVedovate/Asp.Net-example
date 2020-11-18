using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Domain.PartidoAggregate
{
    public class PartidoValidator : AbstractValidator<PartidoDomain>
    {
        public PartidoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("TESTE123");
            RuleFor(x => x.Cigla).NotEmpty().WithMessage("TESTE123");
            RuleFor(x => x.NumeroEleitoral).NotEmpty();
        }
    }
}
