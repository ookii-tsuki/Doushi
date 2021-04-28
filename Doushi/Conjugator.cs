using System;
using System.Linq;
using System.Text;

namespace Doushi
{
    public static class Conjugator
    {
        private static DataHandler data;

        /// <summary>
        /// Conjugates the verb and returns its inflections
        /// </summary>
        /// <param name="verb">The Japanese verb in dictionary form</param>
        /// <param name="reading">The verb's reading in dictionary form</param>
        public static Inflections Conjugate(string verb, Type type, string reading = "")
        {
            if (data == null)
                data = new DataHandler();

            if (verb.Length < 2 || type == Type.UNKNOWN)
                return null;
            if (!new char[] { 'る', 'う', 'く', 'ぐ', 'す', 'つ', 'む', 'ぶ', 'ぬ' }.Contains(verb[verb.Length - 1]))
                return null;

            reading = reading.Length >= 2 ? reading : null;

            var root = data.ConjData[type.ToString().ToLower()];
            var nonpast = root["non-past"];
            var nonpastPolite = root["non-past-polite"];
            var past = root["past"];
            var pastPolite = root["past-polite"];
            var teForm = root["te-form"];
            var potential = root["potential"];
            var passive = root["passive"];
            var causative = root["causative"];
            var causativePassive = root["causative-passive"];
            var imperative = root["imperative"];

            if (type != Type.SPECIAL_SURU && type != Type.SPECIAL_KURU)
            {                
                reading = reading != null ? reading.Remove(reading.Length - 1) : reading;
                var aru = type == Type.GODAN_SPECIAL_RU;
                verb = aru ? verb.Remove(verb.Length - 2) : verb.Remove(verb.Length - 1);
                var inflections = new Inflections
                {
                    NonPast = new Polarity
                    {
                        Affirmative = verb + nonpast[0],
                        AReading = aru ? verb + nonpast[0] : reading,
                        Negative = verb + nonpast[1],
                        NReading = aru ? verb + nonpast[1] : reading,
                    },
                    NonPastPolite = new Polarity
                    {
                        Affirmative = verb + nonpastPolite[0],
                        AReading = aru ? verb + nonpastPolite[0] : reading,
                        Negative = verb + nonpastPolite[1],
                        NReading = aru ? verb + nonpastPolite[1] : reading,
                    },
                    Past = new Polarity
                    {
                        Affirmative = verb + past[0],
                        AReading = aru ? verb + past[0] : reading,
                        Negative = verb + past[1],
                        NReading = aru ? verb + past[1] : reading,
                    },
                    PastPolite = new Polarity
                    {
                        Affirmative = verb + pastPolite[0],
                        AReading = aru ? verb + pastPolite[0] : reading,
                        Negative = verb + pastPolite[1],
                        NReading = aru ? verb + pastPolite[1] : reading,
                    },
                    TeForm = new Polarity
                    {
                        Affirmative = verb + teForm[0],
                        AReading = aru ? verb + teForm[0] : reading,
                        Negative = verb + teForm[1],
                        NReading = aru ? verb + teForm[1] : reading,
                    },
                    Potential = new Polarity
                    {
                        Affirmative = verb + potential[0],
                        AReading = aru ? verb + potential[0] : reading,
                        Negative = verb + potential[1],
                        NReading = aru ? verb + potential[1] : reading,
                    },
                    Passive = new Polarity
                    {
                        Affirmative = verb + passive[0],
                        AReading = aru ? verb + passive[0] : reading,
                        Negative = verb + passive[1],
                        NReading = aru ? verb + passive[1] : reading,
                    },
                    Causative = new Polarity
                    {
                        Affirmative = verb + causative[0],
                        AReading = aru ? verb + causative[0] : reading,
                        Negative = verb + causative[1],
                        NReading = aru ? verb + causative[1] : reading,
                    },
                    CausativePassive = new Polarity
                    {
                        Affirmative = verb + causativePassive[0],
                        AReading = aru ? verb + causativePassive[0] : reading,
                        Negative = verb + causativePassive[1],
                        NReading = aru ? verb + causativePassive[1] : reading,
                    },
                    Imperative = new Polarity
                    {
                        Affirmative = verb + imperative[0],
                        AReading = aru ? verb + imperative[0] : reading,
                        Negative = verb + imperative[1],
                        NReading = aru ? verb + imperative[1] : reading,
                    },
                    Type = type
                };
                return inflections;
            }
            else
            {
                var k = verb[verb.Length - 2] == '来' || verb[verb.Length - 2] == '為';
                verb = k ?
                    verb.Remove(verb.Length - 1) :
                    verb.Remove(verb.Length - 2);

                var inflections = new Inflections
                {
                    NonPast = new Polarity
                    {
                        Affirmative = k ? verb + nonpast[0].Split('|')[1] : verb + nonpast[0].Replace("|", string.Empty),
                        AReading = nonpast[0].Split('|')[0],
                        Negative = k ? verb + nonpast[1].Split('|')[1] : verb + nonpast[1].Replace("|", string.Empty),
                        NReading = nonpast[1].Split('|')[0]
                    },
                    NonPastPolite = new Polarity
                    {
                        Affirmative = k ? verb + nonpastPolite[0].Split('|')[1] : verb + nonpastPolite[0].Replace("|", string.Empty),
                        AReading = nonpastPolite[0].Split('|')[0],
                        Negative = k ? verb + nonpastPolite[1].Split('|')[1] : verb + nonpastPolite[1].Replace("|", string.Empty),
                        NReading = nonpastPolite[1].Split('|')[0]
                    },
                    Past = new Polarity
                    {
                        Affirmative = k ? verb + past[0].Split('|')[1] : verb + past[0].Replace("|", string.Empty),
                        AReading = past[0].Split('|')[0],
                        Negative = k ? verb + past[1].Split('|')[1] : verb + past[1].Replace("|", string.Empty),
                        NReading = past[1].Split('|')[0]
                    },
                    PastPolite = new Polarity
                    {
                        Affirmative = k ? verb + pastPolite[0].Split('|')[1] : verb + pastPolite[0].Replace("|", string.Empty),
                        AReading = pastPolite[0].Split('|')[0],
                        Negative = k ? verb + pastPolite[1].Split('|')[1] : verb + pastPolite[1].Replace("|", string.Empty),
                        NReading = pastPolite[1].Split('|')[0]
                    },
                    TeForm = new Polarity
                    {
                        Affirmative = k ? verb + teForm[0].Split('|')[1] : verb + teForm[0].Replace("|", string.Empty),
                        AReading = teForm[0].Split('|')[0],
                        Negative = k ? verb + teForm[1].Split('|')[1] : verb + teForm[1].Replace("|", string.Empty),
                        NReading = teForm[1].Split('|')[0]
                    },
                    Potential = type == Type.SPECIAL_KURU ?
                    new Polarity
                    {
                        Affirmative = k ? verb + potential[0].Split('|')[1] : verb + potential[0].Replace("|", string.Empty),
                        AReading = potential[0].Split('|')[0],
                        Negative = k ? verb + potential[1].Split('|')[1] : verb + potential[1].Replace("|", string.Empty),
                        NReading = potential[1].Split('|')[0]
                    } :
                    new Polarity
                    {
                        Affirmative = k ? verb.Remove(verb.Length - 1) + "出来る" : verb + potential[0],
                        AReading = potential[0].Remove(potential[0].Length - 1),
                        Negative = k ? verb.Remove(verb.Length - 1) + "出来ない" : verb + potential[1],
                        NReading = potential[1].Remove(potential[1].Length - 2)
                    },
                    Passive = new Polarity
                    {
                        Affirmative = k ? verb + passive[0].Split('|')[1] : verb + passive[0].Replace("|", string.Empty),
                        AReading = passive[0].Split('|')[0],
                        Negative = k ? verb + passive[1].Split('|')[1] : verb + passive[1].Replace("|", string.Empty),
                        NReading = passive[1].Split('|')[0]
                    },
                    Causative = new Polarity
                    {
                        Affirmative = k ? verb + causative[0].Split('|')[1] : verb + causative[0].Replace("|", string.Empty),
                        AReading = causative[0].Split('|')[0],
                        Negative = k ? verb + causative[1].Split('|')[1] : verb + causative[1].Replace("|", string.Empty),
                        NReading = causative[1].Split('|')[0]
                    },
                    CausativePassive = new Polarity
                    {
                        Affirmative = k ? verb + causativePassive[0].Split('|')[1] : verb + causativePassive[0].Replace("|", string.Empty),
                        AReading = causativePassive[0].Split('|')[0],
                        Negative = k ? verb + causativePassive[1].Split('|')[1] : verb + causativePassive[1].Replace("|", string.Empty),
                        NReading = causativePassive[1].Split('|')[0]
                    },
                    Imperative = new Polarity
                    {
                        Affirmative = k ? verb + imperative[0].Split('|')[1] : verb + imperative[0].Replace("|", string.Empty),
                        AReading = imperative[0].Split('|')[0],
                        Negative = k ? verb + imperative[1].Split('|')[1] : verb + imperative[1].Replace("|", string.Empty),
                        NReading = imperative[1].Split('|')[0]
                    },
                    Type = type
                };
                return inflections;
            }
            
        }
        /// <summary>
        /// tries to find the verb's type then conjugates it and returns its inflections
        /// </summary>
        /// <param name="verb">The Japanese verb in dictionary form</param>
        /// <param name="reading">The verb's reading in dictionary form</param>
        public static Inflections Conjugate(string verb, string reading)
        {
            return Conjugate(verb, TryFindType(verb, reading.Length > 0 ? reading : verb), reading);
        }

        /// <summary>
        /// Tries to find the verb's type.
        /// This is not 100% accurate.
        /// </summary>
        /// <param name="verb">The Japanese verb in dictionary form</param>
        /// <param name="reading">The verb's reading in dictionary form</param>
        public static Type TryFindType(string verb, string reading)
        {
            if (data == null)
                data = new DataHandler();

            if (verb.Length < 2 || reading.Length < 2)
                return Type.UNKNOWN;
            
            switch (verb[verb.Length - 1])
            {
                case 'る':
                    if ((verb.EndsWith("する") || verb.EndsWith("為る")) && !data.IrregularGodanRU.Contains(verb))
                        return Type.SPECIAL_SURU;
                    else if ((verb.EndsWith("くる") || verb.EndsWith("来る")) && (!verb.EndsWith("できる") && !verb.EndsWith("出来る") && !data.NonKuru.Contains(verb)))
                        return Type.SPECIAL_KURU;
                    else if (verb.EndsWith("ある") || verb.EndsWith("有る"))
                        return Type.GODAN_SPECIAL_RU;

                    var vowel = GetVowel(reading[reading.Length - 2]);
                    if ((vowel == 'あ' || vowel == 'う' || vowel == 'お'))
                        return Type.GODAN_RU;

                    if (data.IrregularGodanRU.Contains(verb) || verb.EndsWith("入る"))
                        return Type.GODAN_RU;
                    return Type.ICHIDAN; 

                case 'う':
                    if (data.GodanUSpecial.Contains(verb) || verb.EndsWith("問う"))
                        return Type.GODAN_SPECIAL_U;
                    return Type.GODAN_U;

                case 'く':
                    if (verb.EndsWith("いく") || verb.EndsWith("ゆく") || verb.EndsWith("行く") || verb == "てく")
                        return Type.GODAN_SPECIAL_KU;
                    return Type.GODAN_KU;

                case 'ぐ':
                    return Type.GODAN_GU;

                case 'す':
                    return Type.GODAN_SU;

                case 'つ':
                    return Type.GODAN_TSU;

                case 'む':
                    return Type.GODAN_MU;

                case 'ぶ':
                    return Type.GODAN_BU;

                case 'ぬ':
                    return Type.GODAN_NU;

                default:
                    return Type.UNKNOWN;
            }
        }
        public static Type DicToDoushiType(string type)
        {
            switch (type)
            {
                case "v1":
                case "Verb1":
                    return Doushi.Type.ICHIDAN;
                case "v5u":
                case "Verb5U":
                    return Doushi.Type.GODAN_U;
                case "v5k":
                case "Verb5Ku":
                    return Doushi.Type.GODAN_KU;
                case "v5g":
                case "Verb5Gu":
                    return Doushi.Type.GODAN_GU;
                case "v5s":
                case "Verb5Su":
                    return Doushi.Type.GODAN_SU;
                case "v5t":
                case "Verb5Tsu":
                    return Doushi.Type.GODAN_TSU;
                case "v5m":
                case "Verb5Mu":
                    return Doushi.Type.GODAN_MU;
                case "v5b":
                case "Verb5Bu":
                    return Doushi.Type.GODAN_BU;
                case "v5n":
                case "Verb5Nu":
                    return Doushi.Type.GODAN_NU;
                case "v5r":
                case "Verb5Ru":
                    return Doushi.Type.GODAN_RU;
                case "vs-s":
                case "vs-i":
                case "VerbSuruIncluded":
                case "VerbSuruSpecial":
                    return Doushi.Type.SPECIAL_SURU;
                case "vk":
                case "VerbKuSpecial":
                    return Doushi.Type.SPECIAL_KURU;
                case "v5k-s":
                case "Verb5IkuSpecial":
                    return Doushi.Type.GODAN_SPECIAL_KU;
                case "v5u-s":
                case "Verb5USpecial":
                    return Doushi.Type.GODAN_SPECIAL_U;
                case "v5r-i":
                case "Verb5RuIrregular":
                    return Doushi.Type.GODAN_SPECIAL_RU;
                default:
                    return Doushi.Type.UNKNOWN;
            }
        }
        private static char GetVowel(char character)
        {
            character = ToHiragana(character);
            if (new char[] { 'あ', 'か', 'が', 'さ', 'ざ', 'た', 'だ', 'な', 'は', 'ば', 'ぱ', 'ま', 'や', 'ら', 'わ' }.Any(c => c == character))
                return 'あ';
            else if (new char[] { 'い', 'き', 'ぎ', 'し', 'じ', 'ち', 'に', 'ひ', 'び', 'ぴ', 'み', 'り' }.Any(c => c == character))
                return 'い';
            else if (new char[] { 'う', 'く', 'ぐ', 'す', 'ず', 'つ', 'づ', 'ぬ', 'ふ', 'ぶ', 'ぷ', 'む', 'ゆ', 'る' }.Any(c => c == character))
                return 'う';
            else if (new char[] { 'え', 'け', 'げ', 'せ', 'ぜ', 'て', 'で', 'ね', 'へ', 'べ', 'ぺ', 'め', 'れ' }.Any(c => c == character))
                return 'え';
            else if (new char[] { 'お', 'こ', 'ご', 'そ', 'ぞ', 'と', 'ど', 'の', 'ほ', 'ぼ', 'ぽ', 'も', 'よ', 'ろ', 'を' }.Any(c => c == character))
                return 'お';
            else
                return 'ん';
        }
        private static char ToHiragana(char ch)
        {
            return (ch > '\u30a0' && ch < '\u30f7') ? (char)(ch - 96) : ch;
        }
    }

    /// <summary>
    /// The verb categories
    /// </summary>
    public enum Type
    {
        ICHIDAN,
        GODAN_U,
        GODAN_KU,
        GODAN_GU,
        GODAN_SU,
        GODAN_TSU,
        GODAN_MU,
        GODAN_BU,
        GODAN_NU,
        GODAN_RU,
        GODAN_SPECIAL_U,
        GODAN_SPECIAL_KU,
        GODAN_SPECIAL_RU,
        SPECIAL_SURU,
        SPECIAL_KURU,
        UNKNOWN
    }
}
