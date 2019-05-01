using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_DOTNET_CORE.Repository.Business.Account
{
    public interface IAccountRepository
    {
        IEnumerable<GraphQL_DOTNET_CORE.Business.Entities.Account> GetAllAccountsPerOwner(Guid ownerId);
        Task<ILookup<Guid, GraphQL_DOTNET_CORE.Business.Entities.Account>> GetAccountsByOwnerIds(IEnumerable<Guid> ownerIds);
    }
}
