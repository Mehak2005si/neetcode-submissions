public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> mpp = new Dictionary<int, int>();
        for(int i = 0; i<nums.Length; i++){
            if(mpp.ContainsKey(nums[i])){
                return true;
            }
            mpp[nums[i]] = 1;
        }
        return false;
    }
}