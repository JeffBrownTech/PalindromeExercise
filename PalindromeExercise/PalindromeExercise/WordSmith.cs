using System;
using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        if (string.IsNullOrWhiteSpace(word)) return false;

        char[] letters = word.ToCharArray();
        string reversed = new string(letters.Reverse().ToArray());
        return word == reversed;
    }
}
