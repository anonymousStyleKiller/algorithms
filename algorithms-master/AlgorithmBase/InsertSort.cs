using System;

namespace AlgorithmBase
{
    public class InsertSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                var temp = Items[i];
                while (temp != null && i > 0 && temp.CompareTo(Items[i - 1]) == -1)
                {
                    Items[i] = Items[i - 1];
                    i--;
                    SwapCount++;
                    ComparisonCount++;
                }
                Items[i] = temp;
            }
        }
    }
}