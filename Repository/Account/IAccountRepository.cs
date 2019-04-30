using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_DOTNET_CORE.Repository.Owner
{
    public interface IAccountRepository
    {
        IEnumerable<Enitites.Account> GetAllAccountsPerOwner(Guid ownerId);
        Task<ILookup<Guid, Enitites.Account>> GetAccountsByOwnerIds(IEnumerable<Guid> ownerIds);
    }
}
