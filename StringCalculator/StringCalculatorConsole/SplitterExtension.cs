using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorConsole
{
    public static class SplitterExtension
    {
        public static IEnumerable<int> StringSplitter(this string input) => input
            .Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x));
    }
}