using System;

namespace AlgorithmBase
{
    public class QuickSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            QSort(0,  Items.Count - 1);
        }

        private void QSort(int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var piov = Sorting(left, right);
            
            QSort(left, piov - 1);
            QSort(piov + 1, right);
        }

        int Sorting(int left, int right)
        {
            var pointer = left;
            
            for (int i = left; i <= right; i++)
            {
                if (Items[i].CompareTo(Items[right])== -1)
                {
                    Swap(pointer, i);
                    pointer++;
                }
            }

            Swap(pointer, right);
            return pointer;
        }
    }
}