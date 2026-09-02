public class linearSearch
{
    public static void Main()
    {
        int[] a = [4,2,2,1,9];
        int target = 2 ;
        findElement(a,target);
    }

    public static void findElement(int[] inputArray,int targetValue)
    {
        bool foundTarget =false;
        for(int i=0; i<inputArray.Length ; i++)
        {
            if(inputArray[i] == targetValue)
            {
                Console.WriteLine($"Target element found at {i} ");
                foundTarget =true;
            }
        }
        
        if(!foundTarget)
        {
            Console.WriteLine("Given target not found in array");
        }
    }
}