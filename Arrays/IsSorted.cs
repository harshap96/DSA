class IsSorted
{
    public static void Main()
    {
        int[] arr = [1,2,3,4,5,6];
        int[] arr2 = [1,2,4,3,5,6];

        Console.WriteLine($"arr Is Sorted? {isSorted(arr)}");
        Console.WriteLine($"arr2 Is Sorted? {isSorted(arr2)}");
    }

    static bool isSorted(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
        {
            return true; 
        }

        for(int i =0 ; i <arr.Length-1; i++)
        {
            if(arr[i] > arr[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}