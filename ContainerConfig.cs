using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace CheckOnCorrectPlacement
{

   public class ContainerConfig
    {
        public static IContainer ConfigureDatabase()
        {
            var builder = new ContainerBuilder();   
            builder.RegisterType<DatabaseSource>().As<ISource>();
            return builder.Build();
        }
        public static IContainer ConfigureFilesource()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<FileSource>().As<ISource>(); 
            return builder.Build();
        }
    }
    }

