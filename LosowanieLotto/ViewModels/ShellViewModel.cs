using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace LosowanieLotto.ViewModels
{
    public class ShellViewModel : Screen
    {
        private int _drawNumber = 2;

        public int DrawNumber
        {
            get { return _drawNumber; }
            set
            {
                _drawNumber = value;
                NotifyOfPropertyChange(() =>DrawNumber );
            }
        }

        public bool CanStartDrawNumber(int drawNumber)
        {

            return true;
        }
        public void startDrawNumber( )
        {
            
        }
    }
}