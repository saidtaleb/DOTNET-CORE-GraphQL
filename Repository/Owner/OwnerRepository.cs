using GraphQL_DOTNET_CORE.Enitites.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_DOTNET_CORE.Repository.Account
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationContext _context;

        public OwnerRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Enitites.Owner> GetAll() => _context.Owners.ToList();

        public Enitites.Owner GetById(Guid id) => _context.Owners.SingleOrDefault(o => o.Id.Equals(id));

        public Enitites.Owner CreateOwner(Enitites.Owner owner)
        {
            owner.Id = Guid.NewGuid();
            _context.Add(owner);
            _context.SaveChanges();
            return owner;
        }

        public Enitites.Owner UpdateOwner(Enitites.Owner dbOwner, Enitites.Owner owner)
        {
            dbOwner.Name = owner.Name;
            dbOwner.Address = owner.Address;

            _context.SaveChanges();

            return dbOwner;
        }

        public void DeleteOwner(Enitites.Owner owner)
        {
            _context.Remove(owner);
            _context.SaveChanges();
        }
    }
}
