using EmreDemir.Business.Abstract;
using EmreDemir.DataAccess.Abstract;
using EmreDemir.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmreDemir.Business.Concrete
{
    public class WhoManager : IWhoService
    {
        private IWhoDal _whoDal;
        public WhoManager(IWhoDal whoDal)
        {
            _whoDal = whoDal;
        }
        public void add(WhoAmI entity)
        {
            _whoDal.add(entity);
        }

        public void delete(WhoAmI entity)
        {
            _whoDal.delete(entity);
        }

        public WhoAmI Get(int postId = 1)
        {
            return _whoDal.Get(p => p.Id == postId);
        }

        public List<WhoAmI> GetAll()
        {
            return _whoDal.GetAll();
        }

        public void update(WhoAmI entity)
        {
            _whoDal.update(entity);
        }
    }
}
