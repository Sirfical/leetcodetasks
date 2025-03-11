public class Solution {
    static bool CanPartition(string s, int target)
    {
        int n = s.Length;
        bool[] dp = new bool[n + 1];
        dp[0] = true; // Базовый случай: пустая строка

        for (int i = 0; i < n; i++)
        {
            if (!dp[i]) continue; // Если сюда не добрались, пропускаем
            int num = 0;
            for (int j = i; j < n; j++)
            {
                num = num * 10 + (s[j] - '0'); // Формируем число
                if (num > target) break; // Если уже больше i — нет смысла продолжать
                if (num == target || dp[j + 1]) dp[j + 1] = true;
            }
        }

        return dp[n]; // Возможно ли разбиение
    }

    static bool IsValid(int i)
    {
        string squared = (i * i).ToString();
        return CanPartition(squared, i);
    }

    public int GetPunishmentNumber(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (IsValid(i))
                sum += i * i;
        }
        return sum;
    }
}