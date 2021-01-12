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
            RuleFor(x => x.Nome).NotEmpty().WithMessage("TESTE123");
            RuleFor(x => x.PartidoId).NotEmpty();
            RuleFor(x => x.Idade).NotEmpty();
            RuleFor(x => x.Posicao).NotEmpty().WithMessage("TESTE123");
            RuleFor(x => x.Foto).NotEmpty().WithMessage("TESTE123");


        }
    }
}
