class MergeSort
{
    public static void Main()
    {
       int[] arr = [9,8,7,2,6,5]; 
       doMergeSort(arr,0,arr.Length-1);
       printArray(arr);

    }

    static void doMergeSort(int[] arr, int l, int r)
    {
        if(l<r){
            int m = l+(r-l)/2;

            doMergeSort(arr,l,m);
            doMergeSort(arr,m+1,r);

            merge(arr,l,m,r);
        }
    }

    static void merge(int[]arr, int l, int m, int r)
    {
        int n1 = m-l+1;
        int n2 = r-m;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for(int i = 0; i < n1; i++)
        {
            L[i]= arr[l+i];
        }
        for(int j = 0; j < n2; j++)
        {
            R[j]= arr[m+j+i];
        }

        i = 0; 
        j = 0;
        int k = l;
        
        while(i<n1 && j<n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1) {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2) {
            arr[k] = R[j];
            j++;
            k++;
        }

    }

    static void printArray(int[] arr){
        int i;
        for (i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}