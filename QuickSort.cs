class QuickSort
{
    static int partition(int[] arr, int low, int high)
    {
        int pivot = arr[low];
        int i = low-1;
        int j = high+1;

        while (true)
        {
            do
            {
                i++;
            }
            while(arr[i]<pivot);
            do
            {
                j--;
            }
            while(arr[j]>pivot);

            if(i>=j)
                return j;

            Swap(arr, i, j);
        }
    }

    static void quickSort(int[] arr, int low, int high)
    {
        if(low< high){
            int pivot = partition(arr, low, high);

            quickSort(arr, low, pivot);
            quickSort(arr, pivot+1, high);
        }
    }

    static void Swap (int[] arr, int l, int m)
    {
        int temp = arr[l];
        arr[l] = arr[m];
        arr[m] = temp;
    }

    public static void Main()
    {
        int[] arr = [9,8,5,6,4,1];
        quickSort(arr,0,arr.Length-1);
        printArray(arr);
    }

    static void printArray(int[] arr){
        int i;
        for (i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}