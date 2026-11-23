public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> mpp = new Dictionary<int,int>();
        for(int i = 0; i<nums.Length; i++){
            int comp = target - nums[i];
            if(mpp.ContainsKey(comp)){
                return new int[] {mpp[comp], i};
            }
            mpp[nums[i]] = i;
        }
        return new int[] {};
    }
}
