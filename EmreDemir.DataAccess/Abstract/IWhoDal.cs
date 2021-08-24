using EmreDemir.Core.Abstract;
using EmreDemir.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmreDemir.DataAccess.Abstract
{
    public interface IWhoDal:IEntityRepository<WhoAmI>
    {

    }
}
