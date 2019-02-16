using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Model;

namespace ColUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SupplierBLL supbll = new SupplierBLL();
            var sups = supbll.GetSuppliers();
            foreach (var item in sups)
            {
                Console.WriteLine("{0},{1},{2}", item.Id, item.Name, item.Address);
                Console.WriteLine("sb");
            }
            Console.ReadKey();
        }
    }
}
