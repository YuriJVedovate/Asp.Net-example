using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Domain.CandidatoAggregate
{
    public class CandidatoValidator : AbstractValidator<CandidatoDomain>
    {
        public CandidatoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty();
            RuleFor(x => x.PartidoId).NotEmpty().WithMessage("TESTE123");
            RuleFor(x => x.Idade).NotEmpty();
            RuleFor(x => x.Posicao).NotEmpty().WithMessage("TESTE123");
            RuleFor(x => x.Vice).NotEmpty().WithMessage("TESTE123");
        }
    }
}
