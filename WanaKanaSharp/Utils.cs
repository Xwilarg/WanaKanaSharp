namespace WanaKanaSharp
{
    internal static class Utils
    {
        public static bool IsJapanese(this char c)
            => Constants.JapaneseRanges.Any(x => x.Contains(c));
        public static bool IsRomaji(this char c)
            => Constants.RomajiRanges.Any(x => x.Contains(c));

        public static bool IsHiragana(this char c)
            => Range.Contains(c, Constants.HiraganaStart, Constants.HiraganaEnd);
        public static bool IsKatakana(this char c)
            => Range.Contains(c, Constants.KatakanaStart, Constants.KatakanaEnd);
        public static bool IsKanji(this char c)
            => Range.Contains(c, Constants.KanjiStart, Constants.KanjiEnd);

        public static bool IsKana(this char c)
            => c.IsHiragana() || c.IsKatakana();
    }
}
