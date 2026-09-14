class InsertionSort
{
    public static void Main()
    {
       int[] arr = [9,8,7,2,6,5]; 
       doInsertionSort(arr);
       printArray(arr);

    }

    static void doInsertionSort(int[] unsorted)
    {
        int n = unsorted.Length;
        for( int i = 1; i < n; i++)
        {
            int key = unsorted[i];
            int j = i-1;

            while(j>=0 && unsorted[j]> key)
            {
                unsorted[j+1] = unsorted[j];
                j = j-1;
            }

            unsorted[j+1] = key;
        }
        
    }

    static void printArray(int[] arr){
        int i;
        for (i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}