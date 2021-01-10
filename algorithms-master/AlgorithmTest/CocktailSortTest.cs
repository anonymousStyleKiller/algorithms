using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmBase;
using NUnit.Framework;

namespace AlgorithmTest
{
    [TestFixture]
    public class CocktailSortTest
    {
        [Test]
        public void Test1()
        {
            //arrange
            var coctail = new CocktailSort<int>();
            var random = new Random();
            var items = new List<int>();
            for (var i = 0; i < 10000; i++) items.Add(random.Next(0, 100));

            coctail.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            //act
            coctail.Sort();
            
            //assert
            for (var i = 0; i < items.Count; i++) Assert.AreEqual(sorted[i], coctail.Items[i]);
        }
    }
}