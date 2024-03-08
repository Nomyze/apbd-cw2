class Program {
    static double get_avg(int[] arr) {
        int  sum = 0;
        foreach(int number in arr) {
            sum += number;
        }
        return (double) sum / (double) arr.Length;
    }

    static int get_max(int[] arr) {
        int max_val = arr[0];
        for(int i = 1; i < arr.Length; i++)
            if(max_val < arr[i]) 
                max_val = arr[i];
        return max_val;
    }
    static void Main() {
        int[] arr = {1, 2, 3, 4, 5, 5};

        Console.WriteLine(get_avg(arr));
    }
}
