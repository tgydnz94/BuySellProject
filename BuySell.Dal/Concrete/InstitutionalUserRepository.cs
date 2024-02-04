using BuySell.Dal.Abstract;
using BuySell.Dal.Context;
using BuySell.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuySell.Dal.Concrete
{
    public class InstitutionalUserRepository : IInstitutionalUserRepository
    {
        private readonly BuySellContext _context;

        public InstitutionalUserRepository(BuySellContext context) 
        {
            _context = context;
        }
        public void Add(InstitutionalUser ınstitutionalUser)
        {
            _context.Add(ınstitutionalUser);
            _context.SaveChanges();
        }

        public void Delete(InstitutionalUser ınstitutionalUser)
        {
            _context.Remove(ınstitutionalUser);
            _context.SaveChanges();
        }

        public List<InstitutionalUser> GetAll()
        {
            return _context.Set<InstitutionalUser>().ToList();
        }

        public InstitutionalUser GetOne(Expression<Func<InstitutionalUser, bool>> filter)
        {
            return  _context.Set<InstitutionalUser>().SingleOrDefault(filter);
        }

        public void Update(InstitutionalUser ınstitutionalUser)
        {
            _context.Update(ınstitutionalUser);
            _context.SaveChanges();
        }
    }
}
