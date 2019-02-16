using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataServer;
using Model;

namespace DAL
{
    //具体工厂
    public class SupplierFactoy : IFactory<Supplier>
    {
        public IDataServer<Supplier> CreateDAL()
        {
            //具体产品
            return new SupplierDAL();
        }
    }
}
