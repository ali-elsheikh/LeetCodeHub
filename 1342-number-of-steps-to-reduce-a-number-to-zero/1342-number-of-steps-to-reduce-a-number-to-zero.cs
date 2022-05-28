public class Solution {
    private int StepsCount {get;set;}
    public int NumberOfSteps(int num) {
        if(num!=0) {
            if(num%2==0){
                num = num/2;
            }else{
                num--;
            }
            StepsCount++;
            NumberOfSteps(num);
        }
        return StepsCount;
    }
}