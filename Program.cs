class Program {
    static double get_avg(int[] arr) {
        int  sum = 0;
        foreach(int num in arr) {
            sum += num;
        }
        return (double) sum / (double) arr.Length;
    }
    static void Main() {
        int[] arr = {1, 2, 3, 4, 5, 5};

        Console.WriteLine(get_avg(arr));
    }
}
