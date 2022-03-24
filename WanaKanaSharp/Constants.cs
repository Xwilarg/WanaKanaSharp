namespace WanaKanaSharp
{
    // From https://github.com/WaniKani/WanaKana/blob/master/src/constants.js
    internal static class Constants
    {
        public static int LowercaseZenkakuStart { get; } = 0xff41;
        public static int LowercaseZenkakuEnd { get; } = 0xff5a;
        public static int UppercaseZenkakuStart { get; } = 0xff21;
        public static int UppercaseZenkakuEnd { get; } = 0xff3a;
        public static int HiraganaStart { get; } = 0x3041;
        public static int HiraganaEnd { get; } = 0x3096;
        public static int KatakanaStart { get; } = 0x30a1;
        public static int KatakanaEnd { get; } = 0x30fc;
        public static int KanjiStart { get; } = 0x4e00;
        public static int KanjiEnd { get; } = 0x9faf;

        public static Range ZenkakuNumbers { get; } = new(0xff10, 0xff19);
        public static Range ZenkakuUppercase { get; } = new(UppercaseZenkakuStart, UppercaseZenkakuEnd);
        public static Range ZenkakuLowercase { get; } = new(LowercaseZenkakuStart, LowercaseZenkakuEnd);
        public static Range ZenkakuPunctuation1 { get; } = new(0xff01, 0xff0f);
        public static Range ZenkakuPunctuation2 { get; } = new(0xff1a, 0xff1f);
        public static Range ZenkakuPunctuation3 { get; } = new(0xff3b, 0xff3f);
        public static Range ZenkakuPunctuation4 { get; } = new(0xff5b, 0xff60);
        public static Range ZenkakuSymbolsCurrency { get; } = new(0xffe0, 0xffee);

        public static Range HiraganaChars { get; } = new(0x3040, 0x309f);
        public static Range KatakanaChars { get; } = new(0x30a0, 0x30ff);
        public static Range KatakanaPunctuation { get; } = new(0x30fb, 0x30fc);
        public static Range HankakuPunctuation { get; } = new(0xff66, 0xff9f);
        public static Range KanaPunctuation { get; } = new(0xff61, 0xff65);
        public static Range CJKSymbolsPunctuation { get; } = new(0x3000, 0x303f);
        public static Range CommonCJK { get; } = new(0x4e00, 0x9fff);
        public static Range RareCJK { get; } = new(0x3400, 0x4dbf);

        public static Range[] KanaRanges { get; } = new[]
        {
            HiraganaChars,
            KatakanaChars,
            KanaPunctuation,
            HankakuPunctuation
        };

        public static Range[] JAPunctuationRanges { get; } = new[]
        {
            CJKSymbolsPunctuation,
            KanaPunctuation,
            KatakanaPunctuation,
            ZenkakuPunctuation1,
            ZenkakuPunctuation2,
            ZenkakuPunctuation3,
            ZenkakuPunctuation4,
            ZenkakuSymbolsCurrency
        };

        public static Range[] JapaneseRanges { get; } = new[]
        {
            KanaRanges,
            JAPunctuationRanges,
            new[]
            {
                ZenkakuUppercase,
                ZenkakuLowercase,
                ZenkakuNumbers,
                CommonCJK,
                RareCJK
            }
        }.SelectMany(x => x).Distinct().ToArray();

        public static Range ModernEnglish { get; } = new(0x0000, 0x007f);
        public static Range[] HepburnMacronRanges  { get; } = new[]
        {
            new Range(0x0100, 0x0101),
            new Range(0x0112, 0x0113),
            new Range(0x012a, 0x012b),
            new Range(0x014c, 0x014d),
            new Range(0x016a, 0x016b),
        };

        public static Range[] RomajiRanges { get; } = new[]
        {
            HepburnMacronRanges,
            new[]
            {
                ModernEnglish
            }
        }.SelectMany(x => x).ToArray();
    }
}
