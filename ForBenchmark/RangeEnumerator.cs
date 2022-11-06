namespace ForBenchmark;

public struct RangeEnumerator
{
    private readonly int to;
    private readonly int step;

    private int curr;

    public RangeEnumerator(int @from, int to, int step)
    {
        this.to = to + step;
        this.step = step;
        curr = @from - step;
    }

    public bool MoveNext()
    {
        curr += step;
        return curr != to;
    }

    public int Current => curr;
}
