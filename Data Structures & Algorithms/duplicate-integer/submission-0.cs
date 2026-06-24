public class Solution {
    public bool hasDuplicate(int[] nums) {
        var newNums = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++){
            if(newNums.Contains(nums[i])){
                return true;
            }

            newNums.Add(nums[i]);
        }

        return false;
    }
}