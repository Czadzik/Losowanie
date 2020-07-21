using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawLibrary;

namespace LosowanieLotto
{
    public interface IApplication
    {
        List<int> RunDrawNumberForUser();
    }

    public class Application : IApplication
    {
        private IBuisnessLogic _businessLogic;
        public Application(IBuisnessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public List<int> RunDrawNumberForUser()
        {
           return _businessLogic.drawNumbersForUser();
        }
    }
}
