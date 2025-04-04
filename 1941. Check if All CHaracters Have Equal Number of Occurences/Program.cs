using System.Collections;


namespace _1941._Check_if_All_CHaracters_Have_Equal_Number_of_Occurences
{

    public class Solution
    {
        public bool AreOccurrencesEqual(string s)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (letters.ContainsKey(c))
                    letters[c]++;
                else
                    letters[c] = 1;
            }
            

            HashSet<int> occurences = new HashSet<int>(letters.Values);
            return occurences.Count == 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
