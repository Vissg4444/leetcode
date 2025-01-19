class Solution {
public:
bool checkInclusion(string s1, string s2) {
   vector<int> hash1(26,0), hash2(26,0);
   if ( s1.size() > s2.size() ) return false;
   for ( int i = 0; i < s1.size(); i++ )
   {
      hash1[s1[i] - 'a']++;
      hash2[s2[i] - 'a']++;
   }
   for ( int l = 0, r = s1.size() - 1; r < s2.size() - 1;)
   {
      if ( hash2 == hash1 ) return true;
      hash2[s2[l] - 'a']--;
      l++;
      r++;
      hash2[s2[r] - 'a']++;
   }
   return hash2 == hash1;
}
};