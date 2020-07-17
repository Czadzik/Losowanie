using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;


namespace LosowanieLotto
{
  public static class ContainerConifg
    {
        public static IContainer Configuer()
        {
            var builder=new ContainerBuilder();
            builder.RegisterType<DrawNumbers>().As<IDrawNumbers>();
            return builder.Build();
        }
    }
}
