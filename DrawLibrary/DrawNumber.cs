using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LosowanieLotto
{
    public interface IDrawNumber
    {
        List<int> drawNumbers(List<int> ListOFNumbers);
        bool[] checkNumbers(List<int> UserListOFNumbers, List<int> DrawListOfNumbers);
    }

    public class DrawNumber : IDrawNumber
    {
   
        public List<int> drawNumbers(List<int> ListOFNumbers)
        {
            Random random= new Random();

            for (int i = 0; i < ListOFNumbers.Capacity; i++)
            {
                ListOFNumbers.Add(random.Next(1, 49));

            }
            return ListOFNumbers;
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
                //TODO Poprawić zeby nie kasowało tablicy
            }
            return shoot;
        }
        


    }
}
