// Written by Jay Gunderson
// 11/16/2024

namespace _66._Plus_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();
            int[] anArray = {2, 1, 3, 9, 9, };
            foreach (int i in anArray)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\n");
            int[] answer = aSolution.PlusOne(anArray);
            foreach(int i in answer)
            {
                Console.Write(i + "\t");
            }
        }
    }
}
