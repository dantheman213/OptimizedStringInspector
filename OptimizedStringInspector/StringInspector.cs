using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;


namespace OptimizedStringInspector
{
    public static class StringInspector
    {
        private const int maxAsciiVal = 128; // Max ASCII char value

        // Only searching characters that are ASCII
        public static List<Char> FindMostOccurredChar(string phrase)
        {
            if(String.IsNullOrEmpty(phrase)) 
            {
                return null;
            }

            IEnumerable<Char> input = phrase.ToArray<Char>();
            int[] refinedPhrase = new int[maxAsciiVal]; // create temp array of same size as max ASCII length

            // Remove non-ASCII characters (improves performance dramatically)
            foreach(char c in input) 
            {
                if (c > maxAsciiVal)
                    continue;

                refinedPhrase[c] = refinedPhrase[c] + 1;
            }

            List<Char> topCharacters = new List<Char>();
            int currentAsciiVal = int.MinValue;

            // Go through ASCII-only list and find the most occurring character in the ASCII spectrum.
            for (int k = 33; k < refinedPhrase.Length; k++) 
            {
                if (refinedPhrase[k] > currentAsciiVal) 
                {
                    // add the most frequent character and clear the existing data in the structure.
                    currentAsciiVal = refinedPhrase[k];
                    topCharacters.Clear();

                    topCharacters.Add( (char)k );
                } 
                else if (refinedPhrase[k] == currentAsciiVal) 
                {
                    // new character occurs the same in frequency; just add to structure.
                    topCharacters.Add( (char)k );
                }
            }

            return topCharacters;
        }

    }
}
