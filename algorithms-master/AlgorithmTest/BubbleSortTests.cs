using System;
using System.Collections.Generic;
using AlgorithmBase;
using NUnit.Framework;

namespace AlgorithmTest
{
    [TestFixture]
    public class BubbleSortTest
    {
        [Test]
        public void Test1()
        {
            //arrange
            var bubble = new BubbleSort<int>();
            var random = new Random();
            var items = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                items.Add(random.Next(0, 100));
            }

            bubble.Items.AddRange(items);

            //act
            items.Sort();
            bubble.Sort();
            
            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], bubble.Items[i]);
            }
        }
    }
}