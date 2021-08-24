using EmreDemir.Core.Concrete.EntityFramework;
using EmreDemir.DataAccess.Abstract;
using EmreDemir.DataAccess.Contexts;
using EmreDemir.DataAccess.Contexts.PostgreSql;
using EmreDemir.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmreDemir.DataAccess.Concrete.EntityFramework
{
    public class EFWhoDal:EFRepositoryBase<WhoAmI, Context> ,IWhoDal
    {
    }
}
