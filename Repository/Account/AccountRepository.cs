using GraphQL_DOTNET_CORE.Enitites.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_DOTNET_CORE.Repository.Owner
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationContext _context;

        public AccountRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Enitites.Account> GetAllAccountsPerOwner(Guid ownerId) => _context.Accounts
        .Where(a => a.OwnerId.Equals(ownerId))
        .ToList();

        public async Task<ILookup<Guid, Enitites.Account>> GetAccountsByOwnerIds(IEnumerable<Guid> ownerIds)
        {
            var accounts = await _context.Accounts.Where(a => ownerIds.Contains(a.OwnerId)).ToListAsync();
            return accounts.ToLookup(x => x.OwnerId);
        }

    }
}
