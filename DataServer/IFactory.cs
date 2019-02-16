using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer
{
    public interface IFactory<T>
    {
        IDataServer<T> CreateDAL();
    }
}
