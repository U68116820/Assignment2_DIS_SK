﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment2_DIS_SK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("\nQuestion 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);

            //Question 2 
            Console.WriteLine("\nQuestion 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("\nQuestion 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] ar1, int n1)
        {
            int[] result = new int[ar1.Length];
            try
            /* 
             * We suspect that this block of the statement can throw 
             * exception so we handled it by placing these statements
             * inside try and handle the exception in the catch block
            */

            {
                for (int a = 0; a < n1; a++)      //for loop to execute statements from n1 to 1.
                {
                    result[a * 2] = ar1[a];

                }
                for (int b = 1; b < n1 + 1; b++)
                {
                    result[(b * 2) - 1] = ar1[n1 + b - 1];

                }

                for (int x = 0; x < result.Length; x++)
                {
                    Console.Write(result[x] + " ");
                }


            }
            catch (Exception e)
            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception Occured while computing ShuffleArray" + e.Message);

                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            /* 
            * We suspect that this block of the statement can throw 
            * exception so we handled it by placing these statements
            * inside try and handle the exception in the catch block
           */
            {
                int move = 0;
                for (int i = 0; i < ar2.Length; i++)
                {
                    if (ar2[i] != 0)
                    {
                        ar2[move] = ar2[i];
                        move++;
                    }
                }

                while (move < ar2.Length)
                {
                    ar2[move] = 0;
                    move++;
                }

                for (int i = 0; i < ar2.Length; i++)
                {
                    Console.Write(ar2[i] + " ");
                }

            }
            catch (Exception e)
            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception Occured while computing MoveZeroes" + e.Message);
                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] ar3)
        {
            try
            /* 
             * We suspect that this block of the statement can throw 
             * exception so we handled it by placing these statements
             * inside try and handle the exception in the catch block
            */
            {
                int cool = 0;
                for (int i = 0; i < ar3.Length; i++)
                {
                    for (int j = i + 1; j < ar3.Length; j++)
                    {
                        if (ar3[i] == ar3[j]) { cool++; }

                    }
                }
                Console.WriteLine(cool);
            }
            catch (Exception e)
            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception Occured while computing Coolpairs" + e.Message);

                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] ar4, int target)
        {
            try
            {
                for (int i = 0; i < ar4.Length; i++)
                {
                    for (int j = i + 1; j < ar4.Length; j++)
                    {
                        if (ar4[i] + ar4[j] == target)
                        {
                            Console.WriteLine("[" + i + "," + j + "]");
                            break;
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s5, int[] indices)
        {
            try
            {
                char[] Charr1 = new char[s5.Length];
                char[] Charr2 = new char[s5.Length];
                // Convert string to array
                for (int i = 0; i < s5.Length; i++)
                {
                    Charr1[i] = s5[i];
                    Charr2[i] = s5[i];
                }
                int x = 0, y = 0;

                // Move characters to specified indices
                while (y < s5.Length && x < indices.Length)
                {
                    int k = indices[x];
                    Charr2[k] = Charr1[y];
                    y += 1;
                    x += 1;
                }
                string output = "";

                // Convert the list to string
                for (x = 0; x < s5.Length; x++)
                {
                    output += Charr2[x];
                }
                Console.WriteLine(output);


            }
            catch (Exception e)
            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception Occured while computing RestoreString" + e.Message);

                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s61, string s62)
        {
            int x = 256;
            bool[] a = new bool[x];
            int[] b = new int[x];

            try
            /* 
             * We suspect that this block of the statement can throw 
             * exception so we handled it by placing these statements
             * inside try and handle the exception in the catch block
            */
            {
                if (s61.Length != s62.Length)
                    return false;

                for (int i = 0; i < x; i++)
                { a[i] = false; }


                for (int i = 0; i < x; i++)
                {
                    b[i] = -1;
                }

                for (int i = 0; i < s61.Length; i++)
                {
                   
                    if (b[s61[i]] == -1)    // current character of s61 is seen first time
                    {

                        if (a[s62[i]] == true)  //current character s62 is seen then one to one mapping is not possible.
                            return false;

                        a[s62[i]] = true;   //Current character of S62 is visited

                        // Store mapping of current characters 
                        b[s61[i]] = s62[i];  //storing mapping of character
                    }
                    else if (b[s61[i]] != s62[i])
                        return false;
                }
                return true;

            }
            catch (Exception e)
            {
                /*
                                * This is a generic Exception handler which means it can handle
                                * all the exceptions. This will execute if the exception is not
                                * handled by previous catch blocks.
                                */
                Console.WriteLine("Exception Occured while computing Isomorphic" + e.Message);
                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] scores)
        {
            try
            /* 
        * We suspect that this block of the statement can throw 
        * exception so we handled it by placing these statements
        * inside try and handle the exception in the catch block
       */
            {
                int[,] result = new int[2, 2];
                int temp = 0;


                Dictionary<int, List<int>> list = new Dictionary<int, List<int>>();
                for (int i = 0; i < 11; i++)
                {
                    if (list.ContainsKey(scores[i, 0]))
                    {
                        list[scores[i, 0]].Add(scores[i, 1]);
                    }
                    else
                    {
                        list.Add(scores[i, 0], new List<int> { scores[i, 1] });
                    }
                }
                foreach (KeyValuePair<int, List<int>> pair in list)
                {
                    pair.Value.Sort();
                    pair.Value.Reverse();
                    result[temp, 0] = pair.Key;
                    result[temp, 1] = (pair.Value.Take(5).Sum() / 5);
                    temp = temp + 1;
                }



                Console.WriteLine("[" + result[0, 0] + "," + result[0, 1] + "]");
                Console.WriteLine("[" + result[1, 0] + "," + result[1, 1] + "]");

            }
            catch (Exception e)
            {
                /*
                                * This is a generic Exception handler which means it can handle
                                * all the exceptions. This will execute if the exception is not
                                * handled by previous catch blocks.
                                */
                Console.WriteLine("Exception Occured while computing Highfive" + e.Message);
                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>
        public static int sumDigitSquare(int n8)
        {
            int output = 0;
            try
            {

                while (n8 != 0)
                {
                    output += (n8 % 10) * (n8 % 10);
                    n8 = n8 / 10;
                }
                return output;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static bool HappyNumber(int n8)
        {

           
            HashSet<int> a = new HashSet<int>();  // store numbers in repeated squaresum process
            a.Add(n8);

            try
            {
                while (true)
                {
                    if (n8 == 1) return true;
                    n8 = sumDigitSquare(n8);
                    if (a.Contains(n8))
                        return false;
                    a.Add(n8);

                }


            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] ar9)
        {
            int diffrence = 0, c;

            try
            /* 
            * We suspect that this block of the statement can throw 
            * exception so we handled it by placing these statements
            * inside try and handle the exception in the catch block
           */
            {
                for (int a = 0; a < ar9.Length; a++)
                {
                    for (int b = a; b < ar9.Length; b++)
                    {
                        if (ar9[b] > ar9[a])
                        {
                            c = ar9[b] - ar9[a];
                            if (c > diffrence) 
                            { 
                                diffrence = c; 
                            }
                        }
                    }
                }
                return diffrence;
            }
            catch (Exception e)

            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception Occured while computing stocks" + e.Message);
                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>
        static int current(int n10)
        {
            if (n10 <= 1)
                return n10;
            return current(n10 - 1) + current(n10 - 2);
        }
        private static void Stairs(int steps)
        {
            try
            {
                Console.WriteLine(current(steps + 1));

            }
            catch (Exception)
            {

                throw;
            }


        }
    }
    
}

