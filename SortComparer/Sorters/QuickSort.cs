namespace SortComparer.Sorters {
    public static class QuickSort {

        public static void Sort(int[] A, int start, int end) {
            if (start >= end) return;
            var middle = (start + end) / 2;
            Sort(A, start, middle);
            Sort(A, middle + 1, end);
            Merge(A, start, middle, end);
        }

    }
}