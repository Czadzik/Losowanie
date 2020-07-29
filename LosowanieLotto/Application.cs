using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using DrawLibrary;

namespace LosowanieLotto
{
    public interface IApplication
    {
        List<int> RunDrawNumberForUser(List<int> _listOfUserNumbers);
        bool[] checkNumbers(List<int> listOfUserNumbers, List<int> listOfNumbersForWin);
        List<int> RunDrawNumber(List<int> _listOfUserNumbers);
    }

    public class Application : IApplication
    {
        private IBuisnessLogic _businessLogic;
       

        public Application(IBuisnessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public List<int> RunDrawNumberForUser(List<int> listOfUserNumbers )
        {
           return _businessLogic.drawNumbersForUser(listOfUserNumbers);
        }
        public List<int> RunDrawNumber(List<int> listOfUserNumbers)
        {
            return _businessLogic.drawNumbersForWin(listOfUserNumbers);
        }

        public bool[] checkNumbers(List<int> listOfUserNumbers, List<int> listOfNumbersForWin)
        {
            return _businessLogic.CheckNumber(listOfUserNumbers, listOfNumbersForWin);
        }
    }
}
