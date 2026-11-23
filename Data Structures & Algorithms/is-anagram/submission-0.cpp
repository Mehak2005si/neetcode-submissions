class Solution {
public:
    bool isAnagram(string s, string t) {
        unordered_map<int,int> mpp1;
        unordered_map<int,int> mpp2;
        for(char c1 : s){
            mpp1[c1]++;
        }
        for(char c2 : t){
            mpp2[c2]++;
        }
        return mpp1 == mpp2;
    }
};
