class SecLargestElement{
  public static void Main()
    {
        int[] arr = [1,2,3,4,5,6];

        int x = findSecLargest(arr);

        if(x == 0 || x == -1)
        {
            Console.WriteLine("No second largest found");
        }
        else
        {
            Console.WriteLine($"Second largest is {x}");
        }
    }

    static int findSecLargest(int[] arr)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        if(arr == null || arr.Length <2)
        {
            return -1;
        }

        for(int i =0;i<arr.Length;i++)
        {
            if(arr[i]>largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if(arr[i]>secondLargest && arr[i]!= largest)
            {
                secondLargest = arr[i];
            }
        }

        return (secondLargest == int.MinValue) ? -1 : secondLargest;
    }


}