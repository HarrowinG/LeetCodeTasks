using System;

namespace LeetCodeTasks.RegularExpressionMatchingFolder
{
    public class Runner
    {
        public void Run()
        {
            var regularExpressionMatching = new RegularExpressionMatching();
            //string s = "aa", p = "a"; //false
            //string s = "aa", p = "a*"; //true
            //string s = "ab", p = ".*"; //true
            //string s = "aa", p = "a*a"; //true
            //string s = "aegvvvvv", p = "a*..v*"; //true
            //string s = "mississippi", p = "mis*is*ip*."; //true
            //string s = "mississippi", p = "mis*is*p*."; //false
            //string s = "aaa", p = "a*a"; //true
            //string s = "aaa", p = "ab*a*c*a"; //true
            //string s = "aaa", p = "ab*a*c*aa"; //true
            //string s = "aaa", p = "ab*a*c*aaa"; //false
            //string s = "aaa", p = "ab*a*c*d"; //false
            //string s = "aaa", p = "ab*a*c*."; //true
            //string s = "aaa", p = "a*a*a*a"; //true
            //string s = "aa", p = "a*b*"; //true
            //string s = "aac", p = "a*b*"; //false
            //string s = "abcda", p = "a*a*.*a"; //true todo
            //string s = "aaaa", p = ".*aa"; //true todo
            //string s = "bcda", p = ".*."; //true todo
            //string s = "bbbba", p = ".*a*a"; //true todo
            string s = "bbbba", p = "a*b*c*.*a*a"; //true todo
            var result = regularExpressionMatching.IsMatch(s, p);
            Console.WriteLine(result);

            // .*abcd.*efg -- aaaabcderfg|abcd|eeeefgpoi|efg
            // .*.a.*
        }
    }
}
