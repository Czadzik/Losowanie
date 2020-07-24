using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using Caliburn.Micro;

namespace LosowanieLotto.ViewModels
{
    public class ShellViewModel : Screen
    {
        List<int> _listOfUserNumbers = new List<int>(6);
        List<int> _listOfDrawNumbers = new List<int>(6);
        int[] numbers=new int[6];

        private int _drawNumber = 2;

        public int DrawNumber0
        {
            get { return _drawNumber; }
            set
            {
                _drawNumber = value;
                NotifyOfPropertyChange(() =>DrawNumber0 );
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
             numbers[0] = -_listOfUserNumbers[0];
              MessageBox.Show(numbers[0].ToString());
              _drawNumber = 99;
            }

        }
    }
}