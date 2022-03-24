namespace WanaKanaSharp
{
    public static class WanaKana
    {
        public static bool IsJapanese(string input)
            => !string.IsNullOrEmpty(input) && input.All(x => x.IsJapanese());

        public static bool IsKana(string input)
            => !string.IsNullOrEmpty(input) && input.All(x => x.IsKana());

        public static bool IsHiragana(string input)
            => !string.IsNullOrEmpty(input) && input.All(x => x.IsHiragana());

        public static bool IsKatakana(string input)
            => !string.IsNullOrEmpty(input) && input.All(x => x.IsKatakana());

        public static bool IsKanji(string input)
            => !string.IsNullOrEmpty(input) && input.All(x => x.IsKatakana());

        public static bool IsRomaji(string input)
            => !string.IsNullOrEmpty(input) && input.All(x => x.IsKatakana());
    }
}