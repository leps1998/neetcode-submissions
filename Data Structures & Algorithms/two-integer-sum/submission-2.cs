public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dictio = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) 
        {
            var sum = target - nums[i];

            if (dictio.ContainsKey(sum))
            {
                return new int[] {dictio[sum], i};
            }

            dictio.TryAdd(nums[i], i);
        }

        return new int[] { - 1, -1};
    }
}
