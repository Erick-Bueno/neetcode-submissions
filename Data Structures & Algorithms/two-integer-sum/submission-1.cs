public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var currentValue = 0;
        var sumValue = 0;
        var result = new int[2];

        while(currentValue < nums.Length ){
            if(currentValue == sumValue){
               sumValue += 1;
            }
            if(nums[currentValue] + nums[sumValue] == target){
                result[0] = currentValue;
                result[1] = sumValue;
                break;
            }
            if(sumValue < nums.Length -1){
                sumValue += 1;
            }
            else{
                currentValue += 1;
                sumValue = 0;
            }
        }

    return result;
    }
}
