class RotateRightByK
{
    public static void Main()
    {
        int[] arr = [1,2,3,4,5,6];
        int k = 2;

        rotateRightByK(arr,k);
        Console.WriteLine(String.Join(",",arr));
    }

    static void rotateRightByK(int[] arr, int k)
    {
        int n = arr.Length;

        k=k%n;

        reverse(arr, k,n-1);
        reverse(arr, 0, k-1);
        reverse(arr,0,n-1);
        
    }

    static void reverse(int[] arr, int i, int j)
    {
        while(i<j){
            int temp = arr[i];
            arr[i]= arr[j];
            arr[j]= temp;
            i++;j--;
        }
    }
}