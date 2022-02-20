
Given an encoded string, return its decoded string.

The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times. Note that k is guaranteed to be a positive integer.

You may assume that the input string is always valid; there are no extra white spaces, square brackets are well-formed, etc.

Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k. For example, there will not be input like 3a or 2[4].

 

Example 1:

Input: s = "3[a]2[bc]"
Output: "aaabcbc"
Example 2:

Input: s = "3[a2[c]]"
Output: "accaccacc"
Example 3:

Input: s = "2[abc]3[cd]ef"
Output: "abcabccdcdcdef"
 

Constraints:

1 <= s.length <= 30
s consists of lowercase English letters, digits, and square brackets '[]'.
s is guaranteed to be a valid input.
All the integers in s are in the range [1, 300].



public class Solution {
    public string DecodeString(string s) 
    {
            Stack<string> outp = new Stack<string>();

            for (int i = 0; i < s.Length; i++)   //3[a]2[bc]
            {
                if (!s[i].Equals(']'))
                {
                    outp.Push(s[i].ToString());
                }
                else
                {
                    string str = "";

                    while (outp.Count > 0 && outp.Peek() != "[")
                    {
                        str = outp.Peek() + str;
                        outp.Pop();
                    }

                    outp.Pop();

                    string cnt = "";

                    while (outp.Count() > 0 && char.IsDigit(Convert.ToChar(outp.Peek()[0])))
                    {
                        cnt = outp.Peek() + cnt;
                        outp.Pop();
                    }

                    for (int k = 0; k < Int32.Parse(cnt); k++)
                    {
                        outp.Push(str);
                    }

                }
            }
            StringBuilder oup = new StringBuilder();
            outp.ToList().ForEach(x => oup.Insert(0,x));
            return oup.ToString();
    }
}
