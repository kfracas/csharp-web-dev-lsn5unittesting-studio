﻿using System;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static bool HasBalancedBrackets(String str)
        {
            char[] array1 = str.ToCharArray();
            if (Array.IndexOf(array1, ']') < Array.IndexOf(array1, '['))
            {
                return false;
            }
            int brackets = 0;
            foreach (char ch in array1)
            {
                if (ch == '[')
                {
                    brackets++;
                }
                else if (ch == ']')
                {
                    brackets--;
                }
            }
            return brackets == 0;
        }
    }
}
