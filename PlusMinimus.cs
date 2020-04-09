
//https://www.hackerrank.com/challenges/plus-minus/problem
//09/04/2020

static void plusMinus(int[] arr) {
        double negativeNumbers = 0;
        double positiveNumbers = 0;
        double zeroNumbers = 0;
        double divisor = arr.Count();
        double result = 0.0;

        foreach(int n in arr){
            
            if(n < 0){
                negativeNumbers++;
            }else if(n > 0){
                positiveNumbers++;
            }else{
                zeroNumbers++;
            }            
        }
        result = positiveNumbers / divisor;
        Console.WriteLine("{0}", result.ToString("N6"));

        result = negativeNumbers / divisor;
        Console.WriteLine("{0}", result.ToString("N6"));

        result = zeroNumbers / divisor;
        Console.WriteLine("{0}", result.ToString("N6"));

    }