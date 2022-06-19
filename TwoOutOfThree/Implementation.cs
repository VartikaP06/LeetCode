using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoOutOfThree
{
    public class Implementation
    {
        public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            var hm = new Dictionary<int, int>();
            var res = new List<int>();

            // Add all distinct numbers in First Array to HashMap with count 1
            for (int i = 0; i < nums1.Length; i++)
            {
                if (!hm.ContainsKey(nums1[i]))
                {
                    hm.Add(nums1[i], 1);
                }
            }

            
            var hs2 = new HashSet<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                // Add all new numbers in Second Array to HashMap with count 1
                if (!hm.ContainsKey(nums2[i]))
                {
                    hm.Add(nums2[i], 1);
                }
                // Increment count of only the first occurance of repeat numbers in Second Array, in HashMap.
                else if (!hs2.Contains(nums2[i]))
                {
                    hm[nums2[i]]++;

                    // If element present in 2 arrays, add to result
                    if (hm[nums2[i]] == 2)
                    {
                        res.Add(nums2[i]);
                    }
                }

                hs2.Add(nums2[i]);
            }

            var hs3 = new HashSet<int>();
            for (int i = 0; i < nums3.Length; i++)
            {
                // Add all new numbers in Third Array to HashMap with count 1
                if (!hm.ContainsKey(nums3[i]))
                {
                    hm.Add(nums3[i], 1);
                }
                // Increment count of only the first occurance of repeat numbers in Third Array, in HashMap.
                else if (!hs3.Contains(nums3[i]))
                {
                    hm[nums3[i]]++;

                    // If element present in 2 arrays, add to result
                    if (hm[nums3[i]] == 2)
                    {
                        res.Add(nums3[i]);
                    }
                }

                hs3.Add(nums3[i]);
            }

            return res;
        }
    }
}
