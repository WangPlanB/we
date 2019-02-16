using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataServer;
using Model;

namespace DALMySql
{
    //具体工厂
    public class SupplierFactory : IFactory<Supplier>
    {
        //具体产品
        public IDataServer<Supplier> CreateDAL()
        {
            return new SupplierDAL();
        }
    }
}
