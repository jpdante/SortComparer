using System.Collections.Generic;

namespace SortComparer.Sorters {
    public static class MergeSort {

        public static void Sort(int[] A, int start, int end) {
            if (start >= end) return;
            var middle = (start + end) / 2;
            Sort(A, start, middle);
            Sort(A, middle + 1, end);
            Merge(A, start, middle, end);
        }

        public static void Merge(int[] A, int start, int middle, int end) {
            var B = new int[A.Length];
            int i;
            int j;
            for (i = start; i < middle; i++) {
                B[i] = A[i];
            }
            for (j = middle + 1; j < end; j++) {
                B[end + middle + 1 - j] = A[j];
            }
            i = start;
            j = end;
            for (var k = start; k < end; k++) {
                if (B[i] <= B[j]) {
                    A[k] = B[i];
                    i++;
                } else {
                    A[k] = B[j];
                    j--;
                }
            }
        }

    }
}