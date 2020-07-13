using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using LosowanieLotto.ViewModels;

namespace LosowanieLotto
{
    class Bootstrapper:BootstrapperBase
    {
        public Bootstrapper()
        {
                Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
