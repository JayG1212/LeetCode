namespace _3._Longest_Substring_Without_Repeating_Characters_
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> characters = new HashSet<char>();
            HashSet<int> maxSubString = new HashSet<int>();
            int currentMax = 0;
            int max = 0; // Default value so it doesn't return wrong value

            for (int i = 0; i < s.Length; i++)
            {
                if (!characters.Contains(s[i]))
                {
                    characters.Add(s[i]);
                    currentMax++;
                }

            }
            maxSubString.Add(currentMax);

            foreach (int i in maxSubString)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;

        }




        internal class Program
        {
            static void Main(string[] args)
            {
                Solution a = new Solution();
                Console.WriteLine(a.LengthOfLongestSubstring(" "));

            }
        }


    }
}
