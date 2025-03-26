public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
                dict.Add(num, 1);
            else
                return true;
        }
        return false;
    }
}
