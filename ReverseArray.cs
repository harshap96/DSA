class ReverseArray
{
    public static void Main()
    {
        int[] arr = [1,2,3,4,5,6];

        reverseArray(arr);

        Console.WriteLine(string.Join(", ", arr)); 
    }

    static void reverseArray(int[] arr)
    {
        if (arr == null || arr.Length == 0) return;
        int left = 0;
        int right = arr.Length -1 ;

        while (left < right)
        {
            (arr[left],arr[right]) = (arr[right],arr[left]);
            left++;
            right--;
        }
    }
}