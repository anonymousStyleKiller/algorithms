using System;

namespace AlgorithmBase
{
    public class BubbleSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var count = Items.Count;
            for (var j = 0; j < count; j++)
            for (var i = 0; i < count - 1 - j; i++)
            {
                var a = Items[i];
                var b = Items[i + 1];
                if (a.CompareTo(b) == 1)
                {
                    Swap(i, i + 1);
                    ComparisonCount++;
                }
            }
        }
    }
}