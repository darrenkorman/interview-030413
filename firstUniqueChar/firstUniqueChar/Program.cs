using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstUniqueChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testValues = {
                                      "abcd",
                                      "abcda",
                                      "abbcda",
                                      "aaabaaccd"
                                  };

            foreach (string test in testValues)
            {
                Console.WriteLine(String.Format("The first unique character in string \"{0}\" is: {1}", test, FindFirstUnique(test)));
            }
        }

        public static char FindFirstUnique(string input)
        {
            List<char> uniques = new List<char>();
            HashSet<char> duplicates = new HashSet<char>();

            foreach (char character in input.ToCharArray())
            {
                if (!duplicates.Contains(character))
                {
                    if (uniques.Contains(character))
                    {
                        // an instance of this character was found previously. we've identified a duplicate.
                        uniques.Remove(character);
                        duplicates.Add(character);
                    }
                    else
                    {
                        // character is unique (so far), put it at the end of uniques list.
                        uniques.Add(character);
                    }
                }
                else
                {
                    // this char has already been found to be a duplicate...
                    // nothing needs to be done...
                }
            }

            return (uniques.Count > 0) ? uniques.FirstOrDefault() : ' ';
        }
    }
}
