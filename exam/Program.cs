using System;
using System.Linq;

namespace exam
{
    // Given the string, check if it is a palindrome.
    // 양쪽 짝 맞추기
    class Program
    {
        static void Main(string[] args)
        {
            String inputString = "aabaa";
            bool b = checkPalindrome(inputString);
            Console.WriteLine(b);
            bool a = checkPalindrome_easy(inputString);
            Console.WriteLine(a);
        }
        static bool checkPalindrome(string inputString)
        {
            char[] ch = inputString.ToCharArray();
            bool b = true;
            for (int i = 0; i < inputString.Length / 2; i++)
            {
                if (ch[i] == ch[inputString.Length - i - 1])
                {
                    continue;
                }
                else
                {
                    b = false;
                    break;
                }
            }
            return b;
        }

        // 다른 버전
        static bool checkPalindrome_easy(string inputString)
        {
            return inputString.SequenceEqual(inputString.Reverse());
        }
    }
    
}
