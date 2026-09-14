public class bubbleSort
{
    
    public static void Main()
    {
        int[] arr = { 9,8,7,6,5,4,3,2,1 };
        doBubbleSort(arr);
        printArray(arr);
    }

    static void doBubbleSort(int[] unsorted)
    {
        int length = unsorted.Length;

        for(int i =0;i<length -1; i++)
        {
            bool swapped = false;
            for(int j=0; j < length-i-1; j++)
            {
                if (unsorted[j] > unsorted[j + 1])
                {
                    int temp = unsorted[j];
                    unsorted[j]= unsorted[j+1];
                    unsorted[j+1]= temp;
                    swapped = true;
                }
            }

            if(swapped == false)
                break;
        }
    }

    static void printArray(int[] arr){
        int i;
        for (i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}