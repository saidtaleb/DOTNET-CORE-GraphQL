using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL_DOTNET_CORE.Enitites;

namespace GraphQL_DOTNET_CORE.Repository.Account
{
    public interface IOwnerRepository
    {
        IEnumerable<Enitites.Owner> GetAll();
        Enitites.Owner GetById(Guid id);
        Enitites.Owner CreateOwner(Enitites.Owner owner);
        Enitites.Owner UpdateOwner(Enitites.Owner dbOwner, Enitites.Owner owner);
        void DeleteOwner(Enitites.Owner owner);
    }
}
