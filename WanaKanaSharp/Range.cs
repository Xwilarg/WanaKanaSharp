namespace WanaKanaSharp
{
    internal struct Range
    {
        public Range(int start, int end)
            => (Start, End) = (start, end);

        public int Start { get; }
        public int End { get; }

        public bool Contains(int value)
            => Contains(value, Start, End);

        public static bool Contains(int value, int start, int end)
            => value >= start && value <= end;
    }
}
