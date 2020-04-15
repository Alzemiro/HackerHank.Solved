//https://www.hackerrank.com/challenges/time-conversion/problem?h_r=next-challenge&h_v=zen
//15/04/2020
static string timeConversion(string s) {
        return DateTime.Parse(s).ToString("HH:mm:ss");

    }