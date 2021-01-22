using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmBase;
using AlgorithmBase.DataStructures;
using NUnit.Framework;

namespace AlgorithmTest
{
    [TestFixture]
    public class SortTests
    {
        Random rnd = new Random();
        private List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();
        
        /// <summary>
        /// SetUp При запуске каждый раз по новой инициализирует
        /// </summary>
        [SetUp]
        public void Init()
        { 
            Items.Clear();
            for (int i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(0, 1000));
            }
            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }
        
        [Test]
        public void BaseSortTest()
        {
            // arrange
            var bases = new AlgorithmBase<int>();
            
            bases.Items.AddRange(Items);
            
            // act 
            bases.Sort();
            
            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bases.Items[i]);
            }
        }
        
        [Test]
        public void BubbleTest()
        {
            // arrange
            var bubble = new BubbleSort<int>();
            
            bubble.Items.AddRange(Items);
            
            // act 
            bubble.Sort();
            
            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }
        }
        
        [Test]
        public void CocktailSortTest()
        {
            // arrange
            var coctail = new CocktailSort<int>();
            
            coctail.Items.AddRange(Items);
            
            // act 
            coctail.Sort();
            
            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], coctail.Items[i]);
            }
        }
        
        [Test]
        public void InsertSortTest()
        {
            // arrange
            var insert = new InsertSort<int>();
            
            insert.Items.AddRange(Items);
            
            // act 
            insert.Sort();
            
            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);
            }
        }
        
        
        [Test]
        public void ShellSortTest()
        {
            // arrange
            var sell = new ShellSort<int>();
            
            sell.Items.AddRange(Items);
            
            // act 
            sell.Sort();
            
            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], sell.Items[i]);
            }
        }
        
        [Test]
        public void TreeSortTest()
        {
            // arrange
            var tree = new TreeSort<int>();
            
            tree.Items.AddRange(Items);
            
            // act 
            tree.Sort();
            
            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], tree.Items[i]);
            }
        }
        
        [Test]
        public void HeapSortTest()
        {
            // arrange
            var heap = new HeapSort<int>();
            
            heap.Items.AddRange(Items);
            
            // act 
            heap.Sort();
            
            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);
            }
        }
        
        [Test]
        public void SelectionSortTest()
        {
            // arrange
            var selectionSort = new SelectionSort<int>();
            
            selectionSort.Items.AddRange(Items);
            
            // act 
            selectionSort.Sort();
            
            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], selectionSort.Items[i]);
            }
        }
    }
}