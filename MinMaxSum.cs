//https://www.hackerrank.com/challenges/mini-max-sum/problem
//09/04/2020

static void miniMaxSum(int[] arr) {
        Array.Sort(arr);
        int[] reverseArray = arr.Reverse().ToArray();               
        long min = arr.Sum() - reverseArray[0];
        long max = arr.Sum() - arr[0];
        
        Console.WriteLine("{0} {1}", min, max);
    }