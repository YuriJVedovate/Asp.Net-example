using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Domain.ElectionAggregate
{
    public class ElectionValidator : AbstractValidator<ElectionDomain>
    {
        public ElectionValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Entourage).NotEmpty().WithMessage("TESTE123");
            RuleFor(x => x.Age).NotEmpty();
            RuleFor(x => x.Occupation).NotEmpty().WithMessage("TESTE123");
            RuleFor(x => x.Patrimony).NotEmpty().WithMessage("TESTE123");
            RuleFor(x => x.Vice).NotEmpty();
        }
    }
}
