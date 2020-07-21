using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Caliburn.Micro;

namespace LosowanieLotto.ViewModels
{
    public class ShellViewModel : Screen
    {
        List<int> _listOfUserNumbers = new List<int>(6);
        List<int> _listOfDrawNumbers = new List<int>(6);


        private int _drawNumber = 2;

        public List<int> DrawNumber1
        {
            get { return _listOfUserNumbers; }
            set
            {
                _listOfUserNumbers = value;
                NotifyOfPropertyChange(() =>DrawNumber1 );
            }
        }

        public bool CanStartDrawNumber(int drawNumber)
        {

            return true;
        }
        public void startDrawNumber( )
        {
            var container = ContainerConifg.Configuer();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
             _listOfUserNumbers= app.RunDrawNumberForUser();
            }

        }
    }
}