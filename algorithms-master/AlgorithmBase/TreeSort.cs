using System;
using AlgorithmBase.DataStructures;

namespace AlgorithmBase
{
    public class TreeSort<T> : AlgorithmBase<T> where T : IComparable, IComparable<T>
    {
        protected override void MakeSort()
        {
            var tree = new Tree<T>(Items);
            var sorted = tree.Inorder();
            Items = sorted;
        }
    }
}