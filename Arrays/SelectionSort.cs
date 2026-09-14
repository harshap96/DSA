class SelectionSort
{
    public static void Main()
    {
       int[] arr = [9,8,7,2,6,5]; 
       doSelectionSort(arr);
       printArray(arr);

    }

    static void doSelectionSort(int[] unsorted)
    {
        int n = unsorted.Length;
        for(int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for(int j= i + 1; j < n; j++)
            {
                if (unsorted[j] < unsorted[min_idx])
                {
                    min_idx = j;
                }
            }
            if(i != min_idx){
                int temp = unsorted[i];
                unsorted[i]= unsorted[min_idx];
                unsorted[min_idx]= temp;
            }
        }
        
    }

    static void printArray(int[] arr){
        int i;
        for (i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}