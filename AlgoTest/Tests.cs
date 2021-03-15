using System.Collections.Generic;
using Algos;
using Algos.Tree;
using NUnit.Framework;

namespace AlgoTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(3, ExpectedResult = 2)]
        [TestCase(4, ExpectedResult = 3)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(6, ExpectedResult = 8)]
        [TestCase(7, ExpectedResult = 13)]
        public int FibTest(int value)
        {
            return Fibonnaci.Fib(value);
        }

        [TestCase()]
        public void CountTrips()
        {
            long s = CountTriplets.countTriplets(new List<long>() {1, 3, 9, 9, 27, 81,}, 3);
        }
        
        
        [TestCase()]
        public void FreqQuery()
        {
            List<List<int>> arr = new List<List<int>>()
            {
                new List<int>() {1, 5},new List<int>() {1, 6},new List<int>() {3, 2},new List<int>() {1, 10},new List<int>() {1, 10},
                new List<int>() {1, 6},new List<int>() {2, 5},new List<int>() {3, 2},
            };

            Algos.FreqQuery.freqQuery(arr);
        }
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 4)]
        [TestCase(7, ExpectedResult = 44)]
        [TestCase(5, ExpectedResult = 13)]
        [TestCase(8, ExpectedResult = 81)]
        [TestCase(20, ExpectedResult = 121415)]
        [TestCase(27, ExpectedResult = 8646064)]
        public int Steps(int value)
        {
            return Algos.Steps.StepPerms(value);
        }


        [TestCase(new int[] { 2,6,8,5}, ExpectedResult = 3)]
        [TestCase(new int[] { 1,5,5,2,6}, ExpectedResult = 4)]
        [TestCase(new int[] { 1,1}, ExpectedResult = 2)]
        public int ranks(int[] value)
        {
            return Algos.Ranks.solution(value);
        }
        
        
        [TestCase("ABDCA", new int[] { 2,-1,-4,-3,3},new int[] { 2, -2, 4, 1, -3}, ExpectedResult = 3)]
        public int sets(string s, int[] x, int[] y)
        {
            return Algos.SetContains.solution(s,x,y);
        }

        [Test]
        public void MaxDepth()
        {

            var tree = new Node(3) {left = new Node(9), right = new Node(3) {left = new Node(15), right = new Node(7)}};

            Assert.AreEqual(2,MaxDepthSearch.MaxDepth(tree)); 
        }
        
        [Test]
        public void IsBinaryTree()
        {

            var tree = new Node(4) {left = new Node(2) { left = new Node(1), right = new Node(3)}, right = new Node(6) {left = new Node(5), right = new Node(7)}};

            Assert.AreEqual(true,BinaryTreeCheck.IsBinaryTree(tree)); 
        }
        
        [Test]
        public void IsBinaryTree_False()
        {

            var tree = new Node(4) {left = new Node(2) { left = new Node(7), right = new Node(3)}, right = new Node(6) {left = new Node(5), right = new Node(7)}};

            Assert.AreEqual(false,BinaryTreeCheck.IsBinaryTree(tree)); 
        }
        [Test]
        public void IsBinaryTree_FalseRight()
        {

            var tree = new Node(4) {left = new Node(2) { left = new Node(7), right = new Node(3)}, right = new Node(6) {left = new Node(5), right = new Node(2)}};

            Assert.AreEqual(false,BinaryTreeCheck.IsBinaryTree(tree)); 
        }
        
        
        [TestCase("dog","god", ExpectedResult = true)]
        [TestCase("dragon","godran", ExpectedResult = true)]
        [TestCase("placebo","plaebo", ExpectedResult = false)]
        [TestCase("placebo","placeboo", ExpectedResult = false)]
        public bool IsAnagram(string s1, string s2)
        {
            return Anagram.IsAnagram(s1, s2);
        }
        
        [TestCase("aaabccddd", ExpectedResult = "abd")]
        public string ReduceString(string s1 )
        {
            return Algos.ReduceString.Reduce((s1));
        }
        
        [TestCase(10, ExpectedResult = 5)]
        public int CountChange(int s)
        {
            
            return Algos.MakeChange.Change(s, new List<long>() {2,5,3,6 });
        }
        
        [TestCase("abcabcbb" , ExpectedResult = 3)]
        [TestCase("tmmzuxt" , ExpectedResult = 5)]
        public int LongestSubstring(string s)
        {
            return Algos.LongestSubstringNoRepeats.LengthOfLongestSubstring(s);
        }


        [TestCase(new int[] { 1 }, 1 , ExpectedResult = 1)]
        [TestCase(new int[] {1,3,5,2,2}, 5, ExpectedResult = 3)]
        [TestCase(new int[] {1,1,1,1,3,4}, 6, ExpectedResult = 5)]
        public int EquilibriumPoint(int[] s, int j)
        {
            return Algos.EquilbriumPoint.Solve(s, j);
        }
        
        
        [TestCase(new int[] {2, 3, 6, 7, 9},new int[]{1, 4, 8, 10}, 5, ExpectedResult = 6)]
        [TestCase(new int[] {100, 112, 256, 349, 770},new int[]{72, 86, 113, 119, 265, 445, 892}, 7, ExpectedResult = 256)]
        public int KthElement(int[] a, int[] b, int j)
        {
            return Algos.KthElementTwoSortedArrays.Solve(a,b, j);
        }
        
        
        [TestCase(new int[] {2, 3, 6, 7, 9}, 8, ExpectedResult = 1)]
        [TestCase(new int[] {1, 2, 2, 1, 1}, 4, ExpectedResult = 2)]
        [TestCase(new int[] {1, 1, 1, 1, 1}, 5, ExpectedResult = 5)]
        public int SmallestSubsetGreaterThanK(int[] a, int j)
        {
            return Algos.SmallestSubsetGreaterThanK.Solve(a, j);
        }
    }
}