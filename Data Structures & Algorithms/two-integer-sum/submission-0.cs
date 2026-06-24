public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dictio = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            var rest = target - nums[i];

            if(dictio.ContainsKey(rest)){
                return new int[] {dictio[rest], i};
            }

            dictio.Add(nums[i], i); 
        }

        return new int[] {-1,-1};
    }
}
