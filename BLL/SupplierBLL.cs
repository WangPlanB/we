using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataServer;
using Model;
using Factory;

namespace BLL
{
    public class SupplierBLL
    {
        //需要一个SupplierDAL
        IDataServer<Supplier> supdal = FactroyBase<Supplier>.CreateDal("sup");
        public List<Supplier> GetSuppliers()
        {
            return supdal.GetData();
        }
    }
}
