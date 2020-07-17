using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosowanieLotto
{
    public interface IDrawNumbers
    {
        void drawNumbers(ref List<int> ListOfNumbers);
        bool[] checkNumbers(List<int> UserListOFNumbers, List<int> DrawListOfNumbers);
    }

    public class DrawNumbers : IDrawNumbers
    {
        List<int> listOfUserNumbers =new List<int>(6);
        List<int> listOfDrawNumbers =new List<int>(6);

        public void drawNumbers(ref List<int> ListOfNumbers)
        {
            Random random= new Random();

            for (int i = 0; i <ListOfNumbers.Capacity; i++)
            {
                ListOfNumbers.Add(random.Next(1, 49));

            }
        }
       

        public bool[] checkNumbers(List<int> UserListOFNumbers, List<int> DrawListOfNumbers)
        {
            bool[] shoot = new[] {false, false, false, false, false, false};
            for (int i = 0; i < UserListOFNumbers.Count; i++)
            {
                for (int j = 0; j < DrawListOfNumbers.Count; j++)
                {
                    if (UserListOFNumbers[i] == DrawListOfNumbers[j])
                    {
                        shoot[i] = true;
                        UserListOFNumbers.RemoveAt(i);
                    }
                }   
            }
            return shoot;
        }
        


    }
}
