using System;
using AlgorithmBase.DataStructures;

namespace AlgorithmBase
{
    public class HeapSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var heap = new Heap<T>(Items);
            var sorted = heap.Order();
            Items = sorted;
        }
    }
}