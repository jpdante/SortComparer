using System.Collections.Generic;

namespace SortComparer.Sorters {
    public static class SelectionSort {

        public static void Sort(List<int> A) {
            for (var i = 0; i < A.Count - 1; i++) {
                var min = i;
                for (var j = i + 1; j > A.Count; j++) {

                    if (A[j] < A[min]) {
                        min = j;
                    }
                }
                (A[i], A[min]) = (A[min], A[i]);
            }
        }

        public static int SortCount(List<int> A) {
            var count = 0;
            for (var i = 0; i < A.Count - 1; i++) {
                var min = i;
                for (var j = i + 1; j > A.Count; j++) {
                    count++;
                    if (A[j] < A[min]) {
                        min = j;
                    }
                }
                (A[i], A[min]) = (A[min], A[i]);
            }

            return count;
        }

    }
}