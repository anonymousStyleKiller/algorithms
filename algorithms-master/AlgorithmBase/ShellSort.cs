using System;

namespace AlgorithmBase
{
    public class ShellSort<T> : AlgorithmBase<T> where T : IComparable
    {
        #region Comments of work this algorithm
// cycle:     the first         the second       the third         the fourth
// was array: (7,3,4,1,2,6,5)   (5,2,4,1,3,6,7)  (2,4,1,3,5,6,7)   (2,1,3,4,5,6,7)
// will be:   (5,2,4,1,3,6,7)   (2,4,1,3,5,6,7)  (2,1,3,4,5,6,7)   (1,2,3,4,5,6,7)
        #endregion
        protected override void MakeSort()
        {
            var step = Items.Count / 2;

            while (step > 0)
            {
                for (int i = step; i < Items.Count; i++)
                {
                    int j = i;
                   
                    while (j >= step && Items[j - step].CompareTo(Items[j]) == 1)
                    {
                        Swap(j-step, j);
                        j -= step;
                    }
                }
                step /= 2;
            }
        }
    }
}