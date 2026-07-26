public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        for(var c = 0; c < nums.Length; c++){
            var restValue = target - nums[c];
            if(dict.ContainsKey(restValue)){
                return new int[2]{dict[restValue], c};
            }
            dict[nums[c]] = c;
        }
                return new int[0];
    }
}
