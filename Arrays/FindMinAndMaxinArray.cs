class FindMinAndMaxinArray
{
    public static void Main()
    {
        int[] arr = [1,2,3,4,5,6];
        
       if (arr.Length == 0)
        {
            Console.WriteLine("Array is empty.");
            return;
        }

        for (int i = 1; i < arr.Length; i++)
        {
            if (numbers[i] < min) 
                min = arr[i];
                
            if (numbers[i] > max) 
                max = arr[i];
        }

        Console.WriteLine($"Minimum: {min}"); 
        Console.WriteLine($"Maximum: {max}"); 

    }

}