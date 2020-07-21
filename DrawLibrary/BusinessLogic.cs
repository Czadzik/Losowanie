using System;
using System.Collections.Generic;
using System.Text;
using LosowanieLotto;

namespace DrawLibrary
{
    public interface IBuisnessLogic
    {
        List<int> drawNumbersForUser();
      // void DrawOnce();
    }

  public  class BusinessLogic : IBuisnessLogic
    {
        private IDrawNumber _drawNumber;
        List<int> listOfUserNumbers = new List<int>(6);
        List<int> listOfDrawNumbers = new List<int>(6);
        private bool[] howManyShoots;
        public BusinessLogic(IDrawNumber drawNumber)
        {
            _drawNumber = drawNumber;
        }

        public List<int> drawNumbersForUser()
        {
            return _drawNumber.drawNumbers( listOfUserNumbers);
        }
        public void DrawOnce()
        {
    
            _drawNumber.drawNumbers(listOfDrawNumbers);
           howManyShoots=_drawNumber.checkNumbers(listOfUserNumbers, listOfDrawNumbers);

        }
        
    }
}
