using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entiity_Framework
{
    public class EFOrderDal:EFRespositoryBase<Order,NorthwindContext>,IOrderDal
    {

    }
}
