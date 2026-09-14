class MoveAllZeros
{
    public static void Main()
    {
       int[] arr = [1,0,2,0,3];

       moveAllZeros(arr);
       Console.WriteLine(string.Join(", ", arr)); 
    }

    static void moveAllZeros(int[] arr)
    {
        int k = 0;
        for(int i =0; i<arr.Length;i++)
        {
            if(arr[i] != 0)
            {
                arr[k]= arr[i];
                k++;
            }
        }
        while (k < arr.Length)
        {
            arr[k]= 0;
            k++;
        }
    }
}