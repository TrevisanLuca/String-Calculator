using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorConsole
{
    public static class SplitterExtension
    {
        //static readonly string[] _defaultSeparators = new string[] { ",", "\n" };
        public static IEnumerable<int> StringSplitterV1(this string input)
        {
            var separator = new string[] { ",", "\n" };
            //string separator = ","; //spostarsi da un array di stringhe semplifica parte del codice ma complica il check SeparatorAtEndOfString
            if (input.StartsWith("//"))
            {
                var separatorTemp = input.Split('\n');
                separator[0] = separatorTemp[0].Substring(2);
                input = input.Substring(separatorTemp[0].Length + 1);
            }

            foreach (var item in separator)
                if (input.EndsWith(item))
                    throw new SeparatorAtEndOfStringExeption("Input can't end with a separator");

            return input
                .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x));
        }
        //public static IEnumerable<int> StringSplitter2(this string input)
        //{
        //    string separator = ",";
        //    var separatorTemp = input.Split("\n", StringSplitOptions.RemoveEmptyEntries);

        //    if (input.StartsWith("//"))
        //    {
        //        separator = separatorTemp[0].Substring(2);
        //        separatorTemp.CopyTo(separatorTemp, 1);
        //    }

        //    if (input.EndsWith(separator) || input.EndsWith("\n"))
        //        throw new SeparatorAtEndOfStringExeption("Input can't end with a separator");

        //    return separatorTemp
        //        .Select(x => x.Split(separator))
        //        .Select(y => int.Parse(y));
        //}
        public static IEnumerable<int> StringSplitter(this string input)
        {
            var tupleInput = ChooseSeparators(input);

            foreach (var item in tupleInput.separators)
                if (tupleInput.input.EndsWith(item))
                    throw new SeparatorAtEndOfStringExeption("Input can't end with a separator");

            return tupleInput.input
                .Split(tupleInput.separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x));
        }
        private static (string input, string[] separators) ChooseSeparators(string input)
        {
            var defaultSeparators = new string[] { ",", "\n" };
            if (!input.StartsWith("//"))
                return (input, defaultSeparators);

            var separatorTemp = input.Split('\n', 2);
            defaultSeparators = new string[] { separatorTemp[0].Substring(2) };
            if (defaultSeparators[0] == "") throw new FormatException("Missing separator");
            return (separatorTemp[1], defaultSeparators);
        }
        private static (string input, string[] separators) ChooseSeparatorsV2(string input)
        {
            var defaultSeparators = new string[] { ",", "\n" };
            if (!input.StartsWith("//"))
                return (input, defaultSeparators);

            var indexOfEndLine = input.IndexOf("\n");
            var separatorTemp = input.Substring(2, indexOfEndLine-2);
            defaultSeparators = new string[] { separatorTemp };
            if (defaultSeparators[0] == "") throw new FormatException("Missing separator");
            return (input.Substring(indexOfEndLine + 1), defaultSeparators);
        }
    }
}