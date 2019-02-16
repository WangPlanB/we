using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using DataServer;

namespace DALMySql
{
    public class SupplierDAL:IDataServer<Supplier>
    {
        public List<Supplier> GetData()
        {
            string sql = "select * from supplier";
            DataTable dt = MySqlDBHelper.GetTable(sql);
            var list = from s in dt.AsEnumerable()
                       select new Supplier
                       {
                           Id = s.Field<int>("id"),
                           Name = s.Field<string>("name"),
                           Address = s.Field<string>("address"),
                           IsDefault = Convert.ToBoolean(s["isDefault"])
                       };

            return list.ToList();
        }

       
    }
}
