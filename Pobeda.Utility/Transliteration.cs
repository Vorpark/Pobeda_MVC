using System.Text.RegularExpressions;

namespace Pobeda.Utility
{
    public enum TransliterationType
    {
        Gost,
        ISO
    }
    public static class Transliteration
    {
        private static Dictionary<string, string> gost = new Dictionary<string, string>();
        private static Dictionary<string, string> iso = new Dictionary<string, string>();
        public static string Front(string text)
        {
            return Front(text, TransliterationType.ISO);
        }
        public static string Front(string text, TransliterationType type)
        {
            string output = text;
            output = Regex.Replace(output, @"\s|\.|\(", " ");
            output = Regex.Replace(output, @"\s+", " ");
            output = Regex.Replace(output, @"[^\s\w\d-]", "");
            output = output.Trim();
            Dictionary<string, string> tdict = GetDictionaryByType(type);
            foreach (KeyValuePair<string, string> key in tdict)
            { 
                output = output.Replace(key.Key, key.Value);
            }
            return output;
        }
        public static string Back(string text)
        {
            return Back(text, TransliterationType.ISO);
        }
        public static string Back(string text, TransliterationType type)
        {
            string output = text;
            Dictionary<string, string> tdict = GetDictionaryByType(type);
            foreach (KeyValuePair<string, string> key in tdict)
            {
                output = output.Replace(key.Value, key.Key);
            }
            return output;
        }
        private static Dictionary<string, string> GetDictionaryByType(TransliterationType type)
        {
            Dictionary<string, string> tdict = iso;
            if (type == TransliterationType.Gost) tdict = gost;
            return tdict;
        }
        static Transliteration()
        {
            gost.Add("Є", "eh");
            gost.Add("І", "i");
            gost.Add("і", "i");
            gost.Add("№", "#");
            gost.Add("є", "eh");
            gost.Add("А", "a");
            gost.Add("Б", "b");
            gost.Add("В", "v");
            gost.Add("Г", "g");
            gost.Add("Д", "d");
            gost.Add("Е", "e");
            gost.Add("Ё", "jo");
            gost.Add("Ж", "zh");
            gost.Add("З", "z");
            gost.Add("И", "i");
            gost.Add("Й", "jj");
            gost.Add("К", "k");
            gost.Add("Л", "l");
            gost.Add("М", "m");
            gost.Add("Н", "n");
            gost.Add("О", "0");
            gost.Add("П", "p");
            gost.Add("Р", "r");
            gost.Add("С", "s");
            gost.Add("Т", "t");
            gost.Add("У", "u");
            gost.Add("Ф", "f");
            gost.Add("Х", "kh");
            gost.Add("Ц", "c");
            gost.Add("Ч", "ch");
            gost.Add("Ш", "sh");
            gost.Add("Щ", "shh");
            gost.Add("Ъ", "");
            gost.Add("Ы", "y");
            gost.Add("Ь", "");
            gost.Add("Э", "eh");
            gost.Add("Ю", "yu");
            gost.Add("Я", "ya");
            gost.Add("а", "a");
            gost.Add("б", "b");
            gost.Add("в", "v");
            gost.Add("г", "g");
            gost.Add("д", "d");
            gost.Add("е", "e");
            gost.Add("ё", "jo");
            gost.Add("ж", "zh");
            gost.Add("з", "z");
            gost.Add("и", "i");
            gost.Add("й", "jj");
            gost.Add("к", "k");
            gost.Add("л", "l");
            gost.Add("м", "m");
            gost.Add("н", "n");
            gost.Add("о", "o");
            gost.Add("п", "p");
            gost.Add("р", "r");
            gost.Add("с", "s");
            gost.Add("т", "t");
            gost.Add("у", "u");
            gost.Add("ф", "f");
            gost.Add("х", "kh");
            gost.Add("ц", "c");
            gost.Add("ч", "ch");
            gost.Add("ш", "sh");
            gost.Add("щ", "shh");
            gost.Add("ъ", "");
            gost.Add("ы", "y");
            gost.Add("ь", "");
            gost.Add("э", "eh");
            gost.Add("ю", "yu");
            gost.Add("я", "ya");
            gost.Add("«", "");
            gost.Add("»", "");
            gost.Add("—", "-");
            gost.Add(" ", "-");
            iso.Add("Є", "ye");
            iso.Add("І", "i");
            iso.Add("Ѓ", "g");
            iso.Add("і", "i");
            iso.Add("№", "#");
            iso.Add("є", "ye");
            iso.Add("ѓ", "g");
            iso.Add("А", "a");
            iso.Add("Б", "b");
            iso.Add("В", "v");
            iso.Add("Г", "g");
            iso.Add("Д", "d");
            iso.Add("Е", "e");
            iso.Add("Ё", "yo");
            iso.Add("Ж", "zh");
            iso.Add("З", "z");
            iso.Add("И", "i");
            iso.Add("Й", "j");
            iso.Add("К", "k");
            iso.Add("Л", "l");
            iso.Add("М", "m");
            iso.Add("Н", "n");
            iso.Add("О", "o");
            iso.Add("П", "p");
            iso.Add("Р", "r");
            iso.Add("С", "s");
            iso.Add("Т", "t");
            iso.Add("У", "u");
            iso.Add("Ф", "f");
            iso.Add("Х", "x");
            iso.Add("Ц", "c");
            iso.Add("Ч", "ch");
            iso.Add("Ш", "sh");
            iso.Add("Щ", "shh");
            iso.Add("Ъ", "");
            iso.Add("Ы", "y");
            iso.Add("Ь", "");
            iso.Add("Э", "e");
            iso.Add("Ю", "yu");
            iso.Add("Я", "ya");
            iso.Add("а", "a");
            iso.Add("б", "b");
            iso.Add("в", "v");
            iso.Add("г", "g");
            iso.Add("д", "d");
            iso.Add("е", "e");
            iso.Add("ё", "yo");
            iso.Add("ж", "zh");
            iso.Add("з", "z");
            iso.Add("и", "i");
            iso.Add("й", "j");
            iso.Add("к", "k");
            iso.Add("л", "l");
            iso.Add("м", "m");
            iso.Add("н", "n");
            iso.Add("о", "o");
            iso.Add("п", "p");
            iso.Add("р", "r");
            iso.Add("с", "s");
            iso.Add("т", "t");
            iso.Add("у", "u");
            iso.Add("ф", "f");
            iso.Add("х", "x");
            iso.Add("ц", "c");
            iso.Add("ч", "ch");
            iso.Add("ш", "sh");
            iso.Add("щ", "shh");
            iso.Add("ъ", "");
            iso.Add("ы", "y");
            iso.Add("ь", "");
            iso.Add("э", "e");
            iso.Add("ю", "yu");
            iso.Add("я", "ya");
            iso.Add("«", "");
            iso.Add("»", "");
            iso.Add("—", "-");
            iso.Add(" ", "-");
        }
    }
}

