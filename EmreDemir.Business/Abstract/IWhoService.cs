using EmreDemir.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmreDemir.Business.Abstract
{
    public interface IWhoService
    {
        void add(WhoAmI entity);
        void update(WhoAmI entity);
        void delete(WhoAmI entity);
        List<WhoAmI> GetAll();
        WhoAmI Get(int postId);
    }
}
