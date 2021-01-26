using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmBase
{
    public class MergeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            Items = Sort(Items);
        }

        private List<T> Sort(List<T> items)
        {
            if (items.Count == 1) return items;

            var middleElement = items.Count / 2;

            var leftCollections = items.Take(middleElement).ToList();
            var rightCollections = items.Skip(middleElement).ToList();

            return Merge(Sort(leftCollections), Sort(rightCollections));
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            var lenght = left.Count + right.Count;
            var leftPointer = 0;
            var rightPointer = 0;
            
            var result = new List<T>();

            for (var i = 0; i < lenght; i++)
                if (leftPointer < left.Count && rightPointer < right.Count)
                {
                    if (left[leftPointer].CompareTo(right[rightPointer])== -1)
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if (rightPointer < right.Count)
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                }

            return result;
        }
    }
}