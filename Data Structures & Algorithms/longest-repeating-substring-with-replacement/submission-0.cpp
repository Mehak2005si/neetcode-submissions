class Solution {
public:
    int characterReplacement(string s, int k) {
        int l=0, r=0, maxLen = 0, maxf =0;
        vector<int> freq(26,0);
        while(r<s.size()){
            freq[s[r]-'A']++;
            maxf = max(maxf, freq[s[r]-'A']);
            if((r-l+1)-maxf>k){
                freq[s[l]-'A']--;
                l++;
            }
            maxLen = max(maxLen, r-l+1);
            r++;
        }
        return maxLen;
    }
};
