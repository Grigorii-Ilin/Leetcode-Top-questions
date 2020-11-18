using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode {
    //https://leetcode.com/problems/single-number/
    class SingleNumber136 {
        public int SingleNumber(int[] nums) {
            return (from num in nums
                    group num by num into g
                    where g.Count() == 1
                    select g.Key).First();
        }              
    }
}
