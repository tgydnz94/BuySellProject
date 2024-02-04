using BuySell.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuySell.Dal.Abstract
{
    public interface IInstitutionalUserRepository
    {
        public void Add(InstitutionalUser ınstitutionalUser);
        public void Update(InstitutionalUser ınstitutionalUser);
        public void Delete(InstitutionalUser ınstitutionalUser);
        List<InstitutionalUser> GetAll();
        InstitutionalUser GetOne(Expression<Func<InstitutionalUser, bool>> filter);
    }
}
