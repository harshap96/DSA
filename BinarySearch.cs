public class binarySearch
{
    public static void Main()
    {
        int[] a = [1,2,3,4,5];
        int target = 5 ;
        var foundAt = findElement(a,target);
        if( foundAt == -1)
        {
            Console.WriteLine("Target not found in given array");
        }
        else
        {
            Console.WriteLine($"Found element at {foundAt}");
        }
    }

    public static int findElement(int[] inputArray,int targetValue)
    {
       int left = 0;
       int right = inputArray.Length-1;
       
       while(left <=right)
        {
            int point = left+ (right-left)/2;
            if(targetValue< inputArray[point])
            {
                right = point-1;
            }
            else if(targetValue > inputArray[point])
            {
                left = point+1;
            }
            else
            {
                return point;
            }
        }

        return -1;
    }
}