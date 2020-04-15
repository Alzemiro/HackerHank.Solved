//https://www.hackerrank.com/challenges/birthday-cake-candles/problem
//15/04/2020


 static int birthdayCakeCandles(int[] ar) {
        
        int candle = ar.Max();
        int candles = 0;
        
        foreach(var i in ar){
            if(i == candle){
                candles++;
            }
        }