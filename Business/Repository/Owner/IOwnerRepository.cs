using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_DOTNET_CORE.Business.Repository.Owner
{
    public interface IOwnerRepository
    {
        IEnumerable<Entities.Owner> GetAll();
        Entities.Owner GetById(Guid id);
        Entities.Owner CreateOwner(Entities.Owner owner);
        Entities.Owner UpdateOwner(Entities.Owner dbOwner, Entities.Owner owner);
        void DeleteOwner(Entities.Owner owner);
    }
}
