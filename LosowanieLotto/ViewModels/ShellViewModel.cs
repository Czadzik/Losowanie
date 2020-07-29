using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Autofac;
using Caliburn.Micro;

namespace LosowanieLotto.ViewModels
{
    public class ShellViewModel : Screen
    {
        List<int> _listOfUserNumbers = new List<int>(6);
        List<int> _listOfDrawNumbers = new List<int>(6); 
        bool [] _arryOfCheck = new bool[6];

        private int _drawNumber0;
        private int _drawNumber1;
        private int _drawNumber2;
        private int _drawNumber3;
        private int _drawNumber4;
        private int _drawNumber5;
        private bool _canDrawNumber=false;
        private string _resultOfDraw;
        private string _resultOfCheck;
        public int DrawNumber0
        {
            get { return _drawNumber0; }
            set
            {
                _drawNumber0 = value;
                NotifyOfPropertyChange(() => DrawNumber0);
            }
        }

        public int DrawNumber1
        {
            get { return _drawNumber1; }
            set
            {
                _drawNumber1 = value;
                NotifyOfPropertyChange(() => DrawNumber1);
            }
        }

        public int DrawNumber2
        {
            get { return _drawNumber2; }
            set
            {
                _drawNumber2 = value;
                NotifyOfPropertyChange(() => DrawNumber2);
            }
        }

        public int DrawNumber3
        {
            get { return _drawNumber3; }
            set
            {
                _drawNumber3 = value;
                NotifyOfPropertyChange(() => DrawNumber3);
            }
        }

        public int DrawNumber4
        {
            get { return _drawNumber4; }
            set
            {
                _drawNumber4 = value;
                NotifyOfPropertyChange(() => DrawNumber4);
            }
        }

        public int DrawNumber5
        {
            get { return _drawNumber5; }
            set
            {
                _drawNumber5 = value;
                NotifyOfPropertyChange(() => DrawNumber5);
            }
        }

        public bool CanStartDrawNumber
        {
            get { return _canDrawNumber;}

        }

        public string ResultOfDraw
        {
            get { return _resultOfDraw; }
            set
            {
                _resultOfDraw = value;


                NotifyOfPropertyChange((() => ResultOfDraw));
            }
          
        }

        public string ResultOfCheck
        {
            get { return _resultOfCheck; }
            set
            {
                _resultOfCheck = value;


                NotifyOfPropertyChange((() => ResultOfCheck));
            }
            
        }

        public void StartDrawNumber(int drawNumber0)
        {
            var container = ContainerConifg.Configuer();

            
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();

                _listOfDrawNumbers.Clear();
                _listOfDrawNumbers = app.RunDrawNumber(_listOfDrawNumbers);


                _arryOfCheck = app.checkNumbers(_listOfDrawNumbers, _listOfUserNumbers);

            }

            ResultOfDraw += _listOfDrawNumbers[0].ToString()+" "+ _listOfDrawNumbers[1].ToString()+ " " + _listOfDrawNumbers[2].ToString()+ " " +
                            _listOfDrawNumbers[3].ToString()+ " " + _listOfDrawNumbers[4].ToString()+ " " + _listOfDrawNumbers[5].ToString()+"\n";

            ResultOfCheck = _arryOfCheck[0].ToString() + " " + _arryOfCheck[1].ToString() + " " +
                            _arryOfCheck[2].ToString() + " " +
                            _arryOfCheck[3].ToString() + " " + _arryOfCheck[4].ToString() + " " +
                            _arryOfCheck[5].ToString();
        
        }
   
        public void StartDrawUserNumber()
        {
            var container = ContainerConifg.Configuer();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
              //  _listOfUserNumbers.Clear();
                _listOfUserNumbers = app.RunDrawNumberForUser(_listOfUserNumbers);

                DrawNumber0 = _listOfUserNumbers[0];
                DrawNumber1 = _listOfUserNumbers[1];
                DrawNumber2 = _listOfUserNumbers[2];
                DrawNumber3 = _listOfUserNumbers[3];
                DrawNumber4 = _listOfUserNumbers[4];
                DrawNumber5 = _listOfUserNumbers[5];
            }

            _canDrawNumber = true;
            NotifyOfPropertyChange(()=>CanStartDrawNumber);
        }
    }
}