class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int,int> mp;
        for(int num : nums){
            mp[num]++;
        }
        vector<vector<int>> bucket(nums.size() + 1);
        for(auto it : mp){
            int element = it.first;
            int frequency = it.second;
            bucket[frequency].push_back(element);
        }
        vector<int> ans;
        for(int frequency = nums.size(); frequency>=1; frequency--){
            for(int element : bucket[frequency]){
                ans.push_back(element);
                if(ans.size() == k){
                    return ans;
                }
            }
        }
        return ans;
    }
};
