using System.Collections.Generic;
using LosowanieLotto;

namespace DrawLibrary
{
    public interface IBuisnessLogic
    {
        List<int> drawNumbersForUser(List<int> listOfUserNumbers);

        List<int> drawNumbersForWin(List<int> listOfUserNumbers);
        bool[] CheckNumber(List<int> listOfUserNumbers, List<int> listOfNumbersForWin);
    }

    public class BusinessLogic : IBuisnessLogic
    {
        private IDrawNumber _drawNumber;


        private bool[] howManyShoots;

        public BusinessLogic(IDrawNumber drawNumber)
        {
            _drawNumber = drawNumber;
        }

        public List<int> drawNumbersForUser(List<int> listOfUserNumbers)
        {
            return _drawNumber.drawNumbers(listOfUserNumbers);
        }

        public List<int> drawNumbersForWin(List<int> drawNumbersForUser)
        {
            return _drawNumber.drawNumbers(drawNumbersForUser);
        }

        public bool[] CheckNumber(List<int> listOfUserNumberss, List<int> listOfNumbersForWinn)
        {
            howManyShoots = _drawNumber.checkNumbers(listOfNumbersForWinn, listOfUserNumberss);
            return howManyShoots;
        }
    }
}