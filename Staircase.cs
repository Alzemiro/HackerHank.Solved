//https://www.hackerrank.com/challenges/staircase/problem
//09/04/2020

  static void staircase(int n) {
        
        for(int i = 0; i < n; i++){
            //Solução utilizando a 5º sobrecarga do metodo string 
            Console.WriteLine(new string('#', i + 1).PadLeft(n, ' '));
        }
}

