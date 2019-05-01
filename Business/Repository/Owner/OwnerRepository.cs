using GraphQL_DOTNET_CORE.Business.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_DOTNET_CORE.Business.Repository.Owner
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationContext _context;

        public OwnerRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Entities.Owner> GetAll() => _context.Owners.ToList();

        public Entities.Owner GetById(Guid id) => _context.Owners.SingleOrDefault(o => o.Id.Equals(id));

        public Entities.Owner CreateOwner(Entities.Owner owner)
        {
            owner.Id = Guid.NewGuid();
            _context.Add(owner);
            _context.SaveChanges();
            return owner;
        }

        public Entities.Owner UpdateOwner(Entities.Owner dbOwner, Entities.Owner owner)
        {
            dbOwner.Name = owner.Name;
            dbOwner.Address = owner.Address;

            _context.SaveChanges();

            return dbOwner;
        }

        public void DeleteOwner(Entities.Owner owner)
        {
            _context.Remove(owner);
            _context.SaveChanges();
        }
    }
}
