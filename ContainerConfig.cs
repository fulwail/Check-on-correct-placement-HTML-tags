using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace ConsoleApp1
{

    class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DatabaseSource>().As<ISource>().Named<ISource>("DatabaseSource");
            builder.RegisterType<FileSource>().As<ISource>().Named<ISource>("FileSource");
            return builder.Build();
        }
        }
    }

