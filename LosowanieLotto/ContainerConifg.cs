using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DrawLibrary;


namespace LosowanieLotto
{
  public static class ContainerConifg
    {
        public static IContainer Configuer()
        {
            var builder=new ContainerBuilder();
            builder.RegisterType<DrawNumber>().As<IDrawNumber>();
            builder.RegisterType<BusinessLogic>().As<IBuisnessLogic>();
            builder.RegisterType<Application>().As<IApplication>();
            return builder.Build();
        }
    }
}
