using System.Collections.Generic;

namespace SortComparer.Sorters {
    public static class BubbleSort {

        public static void Sort(List<int> A) {
            var n = A.Count;
            do {
                var newN = 0;
                for (var i = 1; i <= n - 1; i++) {
                    if (A[i - 1] <= A[i]) continue;
                    (A[i - 1], A[i]) = (A[i], A[i - 1]);
                    newN = i;
                }
                n = newN;
            } while (n > 0);
        }

        public static int SortCount(List<int> A) {
            var count = 0;
            var n = A.Count;
            do {
                var newN = 0;
                for (var i = 1; i <= n - 1; i++) {
                    count++;
                    if (A[i - 1] <= A[i]) continue;
                    (A[i - 1], A[i]) = (A[i], A[i - 1]);
                    newN = i;
                }
                n = newN;
            } while (n > 0);

            return count;
        }

    }
}