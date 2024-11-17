// Written by Jay Gunderson
// 11/16/2024

namespace _35._Search_Insert_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();
            int[] aList = { 1, 3, 5, 6 };
            string stringList = string.Join(", ", aList);
            Console.Write($"What number do you want to find the index of in {stringList}: ");
            int target = Convert.ToInt32(Console.ReadLine());
            int targetPosition = aSolution.SearchInsert(aList, target);

            Console.WriteLine($"\nTarget's index: {targetPosition}" );


        }
    }
}
