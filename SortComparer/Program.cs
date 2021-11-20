using System;
using System.Collections.Generic;
using System.Text;
using SortComparer.Sorters;
using SortComparer.Utils;

namespace SortComparer {
    public class Program {
        public static void Main(string[] args) {
            new Program().Run(args);
        }

        private RandomGenerator random;
        private List<int> vetor1;

        public void Run(string[] args) {
            random = new RandomGenerator();

            vetor1 = new List<int>();
            for (var i = 0; i < 10000; i++) {
                vetor1.Add(random.Next(0, 10000));
            }
            PrintList(vetor1);

            var count = BubbleSort.SortCount(vetor1);
            Console.WriteLine();
            Console.WriteLine($"Count: {count}");

            PrintList(vetor1);
        }

        private void PrintList(List<int> A) {
            var sb = new StringBuilder();
            sb.Append('[');
            if (A.Count > 0) {
                foreach (var i in A) {
                    sb.Append(i);
                    sb.Append(", ");
                }
                sb.Remove(sb.Length - 2, 2);
            }
            sb.Append(']');
            Console.WriteLine(sb);
        }
    }
}
