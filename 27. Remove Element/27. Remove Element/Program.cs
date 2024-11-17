namespace _27._Remove_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();
            int[] aList = { 1, 2, 2, 2, 3, 4, 5, 6, 2, 8, 9, 2, 1 };
            int kAmount = aSolution.RemoveElement(aList, 2);

            Console.WriteLine("K amount: " + kAmount+"\n");
            foreach(int i in aList)
            {
                Console.Write(i + ",\t");
            }
        }
    }
}
