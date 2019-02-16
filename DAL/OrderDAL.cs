using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataServer;
using Model;

namespace DAL
{
    public class OrderDAL : IDataServer<Order>
    {
        public List<Order> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
