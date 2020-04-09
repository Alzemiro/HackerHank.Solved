
//https://www.hackerrank.com/challenges/compare-the-triplets/problem
//09/04/2020

static List<int> compareTriplets(List<int> a, List<int> b) {
        int alice = 0;
        int bob = 0;
        List<int> score = new List<int>();      
        
        for(int i = 0; i < 3; i++){
            
            if(a[i] > b[i]){
                alice++;
            }else if(a[i] < b[i]){
                bob++;
            }

        }         
        
        
        
        score.Add(alice);                   
        score.Add(bob);                    
        return score;