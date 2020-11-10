using Example.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Domain.ElectionAggregate
{
    public interface IElectionRepository :IBaseRepository<ElectionDomain>
    {
    }
}
