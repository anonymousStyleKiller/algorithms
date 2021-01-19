using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmBase;
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
            for (int i = 0; i < 1000; i++)
            {
                Items.Add(rnd.Next(0, 100));
            }
            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
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
      
    }
}