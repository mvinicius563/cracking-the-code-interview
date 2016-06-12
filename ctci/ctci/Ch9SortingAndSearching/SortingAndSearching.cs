using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci.Ch9SortingAndSearching
{
    /*
    Bubble Sort:
        Start at the beginning of an array and swap the first two elements if the first is bigger than the second
        Go to the next pair, etc, continuously making sweeps of the array until sorted  O(n^2) 
    Selection Sort:
        Find the smallest element using a linear scan and move it to the front
        Then, find the second smallest and move it, again doing a linear scan
        Continue doing this until all the elements are in place  O(n^2)
    Merge Sort:
        Sort each pair of elements
        Then, sort every four elements by merging every two pairs
        Then, sort every 8 elements, etc
        O(n log n) expected and worst case 
    Quick Sort:
        Pick a random element and partition the array, such that all numbers that are less than it come before all elements that are greater than it
        Then do that for each half, then each quarter, etc
        O(n log n) expected, O(n^2) worst case
    Bucket Sort:
        Partition the array into a finite number of buckets, and then sort each bucket individually
        This gives a time of O(n + m), where n is the number of items and m is the number of distinct items
    */
    public class SortingAndSearching
    {
        #region Problem1

        /// <summary>
        /// You are given two sorted arrays, A and B, and A has a large enough buffer at the end to hold B
        /// Write a method to merge B into A in sorted order 
        /// </summary>
        public static void Problem1(int[] a, int []b, int sz_a, int sz_b)
        {
            int i = sz_a - 1;
            int j = sz_b - 1;
            int k = sz_a + sz_b - 1;

            //Console.WriteLine($"A: {string.Join(",", a.Take(sz_a))}");
            //Console.WriteLine($"B: {string.Join(",", b)}");

            while (j >= 0 && i >= 0)
            {
                if (a[i] > b[j])
                {
                    //Console.WriteLine($"putting a[{i}] ({a[i]}) at pos {k}");
                    a[k--] = a[i--];                    
                }
                else
                {
                    //Console.WriteLine($"putting b[{j}] ({b[j]}) at pos {k}");
                    a[k--] = b[j--];
                }
            }

            while (j >= 0) { a[k--] = b[j--]; }

            Console.WriteLine(string.Join(",", a));
        }

        public static void Problem1()
        {
            var a = new int[] { 1, 3, 5, 6, 0, 0, 0 };
            var b = new int[] { 2, 4, 8 };
            var sz_a = 4;
            var sz_b = 3;
            Problem1(a, b, sz_a, sz_b);
        }

        #endregion

        #region Problem2

        public class AnagramComparer : StringComparer
        {
            public override int Compare(string x, string y)
            {
                return string.Compare(new string(x.OrderBy(c => c).ToArray()), new string(y.OrderBy(c => c).ToArray()));
            }

            public override bool Equals(string x, string y)
            {
                return Compare(x, y) == 0;
            }

            public override int GetHashCode(string obj)
            {
                return obj.GetHashCode();
            }
        }

        /// <summary>
        /// Write a method to sort an array of strings so that all the anagrams are next to each other 
        /// </summary>
        public static void Problem2()
        {
            List<string> input = new List<string> { "abba", "test", "baba" };
            Console.WriteLine(string.Join(",", input));
            input.Sort(new AnagramComparer());
            Console.WriteLine(string.Join(",", input));
        }

        #endregion


    }
}
