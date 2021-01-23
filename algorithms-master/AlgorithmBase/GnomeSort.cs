using System;

namespace AlgorithmBase
{
    public class GnomeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var i = 1;
            while (i < Items.Count)
                if (i == 0 || Items[i].CompareTo(Items[i - 1]) != -1)
                {
                    i++;
                }
                else
                {
                    Swap(i, i - 1);
                    i--;
                }
        }
    }
}