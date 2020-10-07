using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            Random random = new Random();

            for (int i = 0; i < ListOFNumbers.Capacity; i++)
            {
                ListOFNumbers.Add(random.Next(1, 49));
            }

            return ListOFNumbers;
        }


        public bool[] checkNumbers(List<int> UserListOFNumbers, List<int> DrawListOfNumbers)
        {
            List<int> UsersNumbers = DeepClone(UserListOFNumbers);
            bool[] shoot = new[] {false, false, false, false, false, false};
            for (int i = 0; i < UsersNumbers.Count; i++)
            {
                for (int j = 0; j < DrawListOfNumbers.Count; j++)
                {
                    // z jakiegoś powodu czasem występuje tu problem
                    if (UsersNumbers[i] == DrawListOfNumbers[j])
                    {
                        shoot[i] = true;
                        UsersNumbers.RemoveAt(i);
                    }
                    //////////////////////////////////////////////
                }

             
            }

            return shoot;
        }

    
     
        public static T DeepClone<T>(T obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                stream.Position = 0;
 
                return (T) formatter.Deserialize(stream);
            }
        }
    }
}