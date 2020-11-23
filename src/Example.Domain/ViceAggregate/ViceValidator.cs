using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Domain.ViceAggregate
{
     public class ViceValidator : AbstractValidator<ViceDomain>
    {
        public ViceValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("TESTE123");
            RuleFor(x => x.PartidoId).NotEmpty();
            RuleFor(x => x.Idade).NotEmpty();
        }
    }
}
