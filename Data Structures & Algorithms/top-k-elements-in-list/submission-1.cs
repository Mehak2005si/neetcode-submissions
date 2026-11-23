public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> mpp = new Dictionary<int,int>();
        foreach(int num in nums){
            if(mpp.ContainsKey(num)) mpp[num]++;
            else mpp[num] = 1;
        }
        List<int>[] bucket = new List<int>[nums.Length + 1];
        foreach(var entry in mpp){
            int element = entry.Key;
            int count = entry.Value;
            if(bucket[count] == null){
                bucket[count] = new List<int>();
            }
            bucket[count].Add(element);
        }
        List<int> result = new List<int>();
        for(int i = bucket.Length-1; i>=1; i--){
            if(bucket[i] == null) continue;
            foreach(int num in bucket[i]){
                result.Add(num);
                if(result.Count == k){
                    return result.ToArray();
                }
            }
        }
        return result.ToArray();
    }
}
