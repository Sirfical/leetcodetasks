using System.Text;

var sol = new Solution();
var a = sol.IsAnagram("anagram", "nagaram");

public class Solution {
    public bool IsAnagram(string s, string t)
    {
        var dic = new Dictionary<char, int>();
        foreach (var c in s.Where(c => !dic.TryAdd(c, 1)))
        {
            dic[c]++;
        }

        foreach (var c in t)
        {
            if (dic.ContainsKey(c))
            {
                if (dic[c] != 1)
                    dic[c]--;
                else
                {
                    dic.Remove(c);
                }
            }
            else
                return false;
        }

        return dic.Count != 0;
    }
}