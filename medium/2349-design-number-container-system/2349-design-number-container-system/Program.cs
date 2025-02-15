public class NumberContainers
{
    private Dictionary<int, int> _numbers;
    public NumberContainers()
    {
        _numbers = new Dictionary<int, int>();
    }

    public void Change(int index, int number)
    {
        if (index < 0)
            return;
        _numbers[index] = number;
    }

    public int Find(int number)
    {
        int minIndex = int.MaxValue;
        bool found = false;

        foreach (var pair in _numbers)
        {
            if (pair.Value == number)
            {
                if (pair.Key < minIndex)
                {
                    minIndex = pair.Key;
                    found = true;
                }
            }
        }

        return found ? minIndex : -1;
    }
}