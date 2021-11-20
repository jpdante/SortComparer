using System.Collections.Generic;

namespace SortComparer.Sorters {
    public static class InsertionSort {

        public static void Sort(List<int> A) {
            for (var i = 1; i <= A.Count - 1; i++) {
                var j = i;
                while (j > 0 && A[j - 1] > A[j]) {
                    (A[j], A[j-1]) = (A[j - 1], A[j]);
                    j--;
                }
            }
        }

        public static int SortCount(List<int> A) {
            var count = 0;
            for (var i = 1; i <= A.Count - 1; i++) {
                var j = i;
                while (j > 0 && A[j - 1] > A[j]) {
                    count++;
                    (A[j], A[j - 1]) = (A[j - 1], A[j]);
                    j--;
                }
            }

            return count;
        }

    }
}