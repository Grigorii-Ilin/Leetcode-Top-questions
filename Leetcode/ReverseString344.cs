using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode {
    //https://leetcode.com/problems/reverse-string/
    class ReverseString344 {
        public void ReverseString(char[] s) {
            int maxIndex = s.Length-1;
            for (int i = 0; i < s.Length/2; i++) {
                char tmp = s[i];
                s[i] = s[maxIndex-i];
                s[maxIndex - i] = tmp;
            }
        }
    }
}
