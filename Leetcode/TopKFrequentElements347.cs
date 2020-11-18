using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Leetcode {
    //https://leetcode.com/problems/top-k-frequent-elements/
    class TopKFrequentElements347 {
        public int[] TopKFrequent(int[] nums, int k) {
            return (from num in nums
                    group num by num into g
                    orderby g.Count() descending
                    select g.Key).Take(k).ToArray();
        }
    }
}
