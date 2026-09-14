class FindMissingNumber {
    static long missingNum(int[] arr) {
        int n = arr.Length+1;
        
        long sum = arr.Sum();
        long expSum = n * (n+1)/2;

        return expSum-sum;
    }

    static void Main() {
        int[] arr = { 8, 2, 4, 5, 3, 7, 1 };  
        Console.WriteLine(missingNum(arr));
    }
}