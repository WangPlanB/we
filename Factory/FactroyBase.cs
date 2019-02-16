using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataServer;
using DAL;
using Model;
using DALMySql;
using System.Reflection;
using System.Configuration;

namespace Factory
{
    //工厂生产者 最终获得工厂的产品
    public class FactroyBase<T>
    {
        public static IDataServer<T> CreateDal(string factroyName)
        {
            IFactory<T> factory = null;//工厂对象
            string curPath = AppDomain.CurrentDomain.BaseDirectory;//当前程序的Debug的路径
            string assemblyName = ConfigurationManager.AppSettings["assembly"];//要加载的程序集名称
            string className = ConfigurationManager.AppSettings[factroyName];//要创建的DAL类型全名称
            object obj = Assembly.LoadFrom(curPath + assemblyName + ".dll").CreateInstance(className);
            factory = obj as IFactory<T>;
            return factory.CreateDAL();//获得产品
        }
    }
}
