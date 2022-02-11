using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorConsole
{
    public static class SplitterExtension
    {
        public static IEnumerable<int> StringSplitter(this string input)
        {
            var separator = new string[] { ",", "\n" };

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
    }
}