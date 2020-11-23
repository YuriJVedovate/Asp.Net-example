using Example.Domain.ViceAggregate;
using Example.Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Infra.Data.Repositories
{
    public class ViceRepository : BaseRepository<ViceDomain>, IViceRepository
    {
        public ViceRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
