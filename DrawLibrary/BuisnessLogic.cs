using System;
using System.Collections.Generic;
using System.Text;
using LosowanieLotto;

namespace DrawLibrary
{
    class BuisnessLogic
    {
        private IDrawNumbers _drawNumbers;
         List<int> listOfUserNumbers=new List<int>(6); 
         List<int> listOfDrawNumbers=new List<int>(6);
         private bool[] howManyShoots;
        public BuisnessLogic(IDrawNumbers drawNumbers)
        {
            _drawNumbers = drawNumbers;
        }

        public void drawNumbersForUser()
        {
            _drawNumbers.drawNumbers(ref listOfUserNumbers);
        }
        public void DrawOnce()
        {
    
            _drawNumbers.drawNumbers(ref listOfDrawNumbers);
           howManyShoots=_drawNumbers.checkNumbers(listOfUserNumbers, listOfDrawNumbers);

        }
        
    }
}
