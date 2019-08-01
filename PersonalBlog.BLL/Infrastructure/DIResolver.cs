using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalBlog.DAL.Contracts;
using PersonalBlog.DAL;
using Ninject.Modules;

namespace PersonalBlog.BLL.Infrastructure
{
    public class DIResolver: NinjectModule
    {
        private readonly string _connectionString;
        public DIResolver(string connectionString)
        {
            _connectionString = connectionString;
        }

        //Loads the module into the kernel
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(_connectionString);
        }
    }
}
