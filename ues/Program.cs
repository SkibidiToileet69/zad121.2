using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ues
{
    internal class Program
    {
        public static void MergeSort(List<Worker> workers)
        {
            if (workers.Count <= 1)
                return;

            int middle = workers.Count / 2;
            List<Worker> left = workers.GetRange(0, middle);
            List<Worker> right = workers.GetRange(middle, workers.Count - middle);

            MergeSort(left);
            MergeSort(right);

            Merge(workers, left, right);
        }

        private static void Merge(List<Worker> workers, List<Worker> left, List<Worker> right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i].Salary <= right[j].Salary)
                {
                    workers[k++] = left[i++];
                }
                else
                {
                    workers[k++] = right[j++];
                }
            }

            while (i < left.Count)
            {
                workers[k++] = left[i++];
            }
            while (j < right.Count)
            {
                workers[k++] = right[j++];
            }
        }

        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>
        {
            new Worker("Alice", 5000),
            new Worker("Bob", 6000),
            new Worker("Charlie", 4500),
            new Worker("David", 7000),
            new Worker("Eve", 5500)
        };

            Console.WriteLine("Before sorting:");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            MergeSort(workers);

            Console.WriteLine("\nAfter sorting:");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
        }

    }
}
