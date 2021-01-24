using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmBase
{
    public class LSDRedixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var groups = new List<List<T>>();

            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            var lenght = GetMaxLenght();

            for (int step = 0; step < lenght; step++)
            {
                // Распределение элементов по корзинам
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int) Math.Pow(10, step + 1) / (int) Math.Pow(10, step);
                    groups[value].Add(item);
                }

                Items.Clear();

                // Сборка элементов
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Items.Add(item);
                    }
                }

                // очистка корзин
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }

        private int GetMaxLenght()
        {
            int lenght = 0;

            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Radix sort cann't drop numeral", nameof(item));
                }

                var l = item.GetHashCode().ToString().Length;

                if (l > lenght)
                {
                    lenght = l;
                }
            }

            return lenght;
        }
    }
}