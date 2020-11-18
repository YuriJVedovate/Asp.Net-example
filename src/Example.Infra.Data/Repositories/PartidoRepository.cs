using Example.Domain.PartidoAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Infra.Data.Repositories.Base
{
    public class PartidoRepository : BaseRepository<PartidoDomain>, IPartidoRepository
    {
        public PartidoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
