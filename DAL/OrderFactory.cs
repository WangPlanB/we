using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataServer;
using Model;


namespace DAL
{
    public class OrderFactory : IFactory<Order>
    {
        public IDataServer<Order> CreateDAL()
        {
            throw new NotImplementedException();
        }
    }
}
