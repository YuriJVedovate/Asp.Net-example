using Example.Domain.ElectionAggregate;
using Example.Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Infra.Data.Repositories
{
    public class ElectionRepository : BaseRepository<ElectionDomain>, IElectionRepository
    {
        public ElectionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
