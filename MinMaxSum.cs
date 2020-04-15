//https://www.hackerrank.com/challenges/mini-max-sum/problem
//09/04/2020

static void miniMaxSum(int[] arr) {
        Array.Sort(arr);
        int[] reverseArray = arr.Reverse().ToArray();               
        long min = arr.Sum(x => (long)x) - reverseArray[0];
        long max = arr.Sum(x => (long)x) - arr[0];
        
        Console.WriteLine("{0} {1}", min, max);
        
    }

static void miniMaxSum(int[] arr) {

    long min = 0, max = 0, sum = 0;
    min = arr[0];
    max = min;
    sum = min;

    for(int i = 0; i < arr.Count(); i++){
        
        sum += arr[i];

        if(arr[i] < min){
            min = arr[i];
        }
        if(arr[i] > max){
            max = arr[i];
        }

    }
    Console.WriteLine((sum - max) + " " + (sum - min));
}