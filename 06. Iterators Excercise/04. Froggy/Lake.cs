using System.Collections;
using System.Collections.Generic;

public class Lake : IEnumerable<int>
{
    public Lake(params int[] stones)
    {
        this.stones = new List<int>(stones);
    }
    private List<int> stones;
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < stones.Count; i += 2)
        {
            yield return stones[i];
        }
        if (stones.Count > 1)
        {
            if (stones.Count % 2 == 0)
            {
                for (int i = stones.Count - 1; i >= 0; i -= 2)
                {
                    yield return stones[i];
                }
            }
            else
            {
                for (int i = stones.Count - 2; i >= 0; i -= 2)
                {
                    yield return stones[i];
                }
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}