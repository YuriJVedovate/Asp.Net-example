using Example.Domain.CandidatoAggregate;
using Example.Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Infra.Data.Repositories
{
    public class CandidatoRepository : BaseRepository<CandidatoDomain>, ICandidatoRepository
    {
        public CandidatoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
