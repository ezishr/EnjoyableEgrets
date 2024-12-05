/*
    *Name: Enjoyable Egrets
    * Email: vopq @mail.uc.edu
    * Assignment Number: Final Project
    * Due Date: Dec 5th, 2024
    * Course #/Section: IS 3050 - 002
    * Semester/Year: Fall 2024
    * Brief Description of the assignment: Build a website that shows a list of LeetCode problems and allows users to invoke the solutions.
    * Citations: ChatGPT; https://www.geeksforgeeks.org/c-sharp-list-class/
    *Anything else that's relevant: N/A
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// This class is used to store the information of a LeetCode problems.
namespace HackArena.Models
{
    public class LeetCodeService
    {
        public readonly List<LeetCodeProblem> ProblemList = new List<LeetCodeProblem> // A list of problems with each problem being an object of LeetCodeProblem class
        {
            new LeetCodeProblem
            {
                ID = 1,
                Title = "N-Queens II",
                Description = "The N-Queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other. " +
                  "Given an integer n, return the number of distinct solutions to the n-queens puzzle. The input n represents the size of the chessboard, " +
                  "and the output is the total number of valid configurations. The solution uses a backtracking algorithm to explore all valid placements.",

                Solution = @"public class Solution
                {
                    public int TotalNQueens(int n)
                    {
                        int count = 0;
                        int[] queens = new int[n]; // Array to track queen positions (queens[row] = col)
                        Array.Fill(queens, -1);

                        SolveNQueens(0, n, queens, ref count);
                        return count;
                    }

                    private void SolveNQueens(int row, int n, int[] queens, ref int count)
                    {
                        if (row == n)
                        {
                            // All queens placed successfully
                            count++;
                            return;
                        }

                        for (int col = 0; col < n; col++)
                        {
                            if (IsSafe(row, col, queens))
                            {
                                queens[row] = col; // Place queen at (row, col)
                                SolveNQueens(row + 1, n, queens, ref count); // Try to place queen in next row
                                queens[row] = -1; // Backtrack
                            }
                        }
                    }

                    private bool IsSafe(int row, int col, int[] queens)
                    {
                        for (int prevRow = 0; prevRow < row; prevRow++)
                        {
                            int prevCol = queens[prevRow];

                            // Check column conflict
                            if (prevCol == col)
                                return false;

                            // Check diagonal conflict
                            if (Math.Abs(prevCol - col) == Math.Abs(prevRow - row))
                                return false;
                        }
                        return true;
                    }
                }",
                Difficulty = "Hard",
                TestCases = new List<TestCase> // A list of test cases with each test case being an object of TestCase class
                {
                    new TestCase
                    {
                        ProblemOrder = 1,
                        Input = "4",
                        Output = "2",
                        Explanation = "There are two distinct solutions for a 4x4 chessboard.",
                    },

                    new TestCase
                    {
                        ProblemOrder = 2,
                        Input = "8",
                        Output = "92",
                        Explanation = "There are 92 distinct solutions for an 8x8 chessboard.",
                    },

                }
            },

            new LeetCodeProblem
            {
                ID = 2,
                Title = "Text Justification",
                Description = "Given an array of strings words and a width maxWidth, format the text such that each line has exactly maxWidth characters and is fully justified. " +
                  "You should pack your words in a greedy approach; that is, pack as many words as you can in each line. Pad extra spaces ' ' when necessary so that each line " +
                  "has exactly maxWidth characters. Extra spaces between words should be distributed as evenly as possible. If the number of spaces on a line does not divide evenly " +
                  "between words, the empty slots on the left will be assigned more spaces than the slots on the right. For the last line of text, it should be left-justified, " +
                  "and no extra space is inserted between words.",

                Solution = @"public class Solution
                {
                    public IList<string> FullJustify(string[] words, int maxWidth)
                    {
                        var result = new List<string>();
                        int index = 0;

                        while (index < words.Length)
                        {
                            int lineStart = index;
                            int lineLength = words[index++].Length;

                            // Pack as many words as possible into the current line
                            while (index < words.Length && lineLength + words[index].Length + 1 <= maxWidth)
                            {
                                lineLength += words[index].Length + 1; // Include space for each word
                                index++;
                            }

                            int lineEnd = index - 1;
                            int numWords = lineEnd - lineStart + 1;
                            bool isLastLine = (index == words.Length);

                            // Build the line
                            result.Add(ConstructLine(words, lineStart, lineEnd, numWords, lineLength, maxWidth, isLastLine));
                        }

                        return result;
                    }

                    private string ConstructLine(string[] words, int start, int end, int numWords, int lineLength, int maxWidth, bool isLastLine)
                    {
                        // If it's the last line or there's only one word, left-justify
                        if (isLastLine || numWords == 1)
                        {
                            var sb = new StringBuilder();
                            for (int i = start; i <= end; i++)
                            {
                                sb.Append(words[i]);
                                if (i < end) sb.Append(' '); // Add a single space between words
                            }
                            while (sb.Length < maxWidth)
                            {
                                sb.Append(' '); // Pad the end with spaces
                            }
                            return sb.ToString();
                        }

                        // Fully justify the line
                        int totalSpaces = maxWidth - (lineLength - (numWords - 1));
                        int spaceBetween = totalSpaces / (numWords - 1); // Minimum spaces between words
                        int extraSpaces = totalSpaces % (numWords - 1);  // Extra spaces to distribute

                        var justifiedLine = new StringBuilder();
                        for (int i = start; i <= end; i++)
                        {
                            justifiedLine.Append(words[i]);
                            if (i < end) // Add spaces between words
                            {
                                int spacesToAdd = spaceBetween + (extraSpaces-- > 0 ? 1 : 0);
                                justifiedLine.Append(new string(' ', spacesToAdd));
                            }
                        }

                        return justifiedLine.ToString();
                    }
                }",

                Difficulty = "Hard",
                TestCases = new List<TestCase>
                {
                    new TestCase
                    {
                        ProblemOrder = 1,
                        Input = "words = [\"This\", \"is\", \"an\", \"example\", \"of\", \"text\", \"justification.\"], maxWidth = 16",
                        Output = "[\"This    is    an\", \"example  of text\", \"justification.  \"]",
                        Explanation = "The words are packed into lines with exactly 16 characters. The spaces between words are distributed evenly except on the last line, which is left-justified.",
                    },

                    new TestCase
                    {
                        ProblemOrder = 2,
                        Input = "words = [\"What\", \"must\", \"be\", \"acknowledgment\", \"shall\", \"be\"], maxWidth = 16",
                        Output = "[\"What   must   be\", \"acknowledgment  \", \"shall be        \"]",
                        Explanation = "The words are packed into lines with exactly 16 characters. The last line is left-justified, and spaces are added only at the end.",
                    },

                }
            },

            new LeetCodeProblem
            {
                ID = 3,
                Title = "Candy Distribution",
                Description = "There are n children standing in a line. Each child is assigned a rating value given in the integer array ratings. " +
                  "You are giving candies to these children subjected to the following requirements: " +
                  "1. Each child must have at least one candy. " +
                  "2. Children with a higher rating get more candies than their neighbors. " +
                  "Return the minimum number of candies you need to have to distribute the candies to the children.",
                Solution = @"public class Solution
                {
                    public int Candy(int[] ratings)
                    {
                        int n = ratings.Length;
                        int[] candies = new int[n];

                        // Initialize all children with at least one candy
                        Array.Fill(candies, 1);

                        // Left-to-right pass: Ensure higher-rated children get more candies than left neighbors
                        for (int i = 1; i < n; i++)
                        {
                            if (ratings[i] > ratings[i - 1])
                            {
                                candies[i] = candies[i - 1] + 1;
                            }
                        }

                        // Right-to-left pass: Ensure higher-rated children get more candies than right neighbors
                        for (int i = n - 2; i >= 0; i--)
                        {
                            if (ratings[i] > ratings[i + 1])
                            {
                                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                            }
                        }

                        // Sum up the total candies
                        return candies.Sum();
                    }
                }",

                Difficulty = "Hard",
                TestCases = new List<TestCase>
                {
                    new TestCase
                    {
                        ProblemOrder = 1,
                        Input = "ratings = [1, 0, 2]",
                        Output = "5",
                        Explanation = "The child at index 1 gets 1 candy, index 0 gets 2 candies, and index 2 gets 2 candies. Minimum candies needed: 5.",
                    },

                    new TestCase
                    {
                        ProblemOrder = 2,
                        Input = "ratings = [1, 2, 2]",
                        Output = "4",
                        Explanation = "The child at index 0 gets 1 candy, index 1 gets 2 candies, and index 2 gets 1 candy. Minimum candies needed: 4.",
                    },

                }
            },

            new LeetCodeProblem
            {
                ID = 4,
                Title = "Valid Number",
                Description = "Given a string s, return whether s is a valid number. A valid number can be an integer or a decimal number, optionally followed by an exponent. " +
                  "For example, the following are valid numbers: '2', '0089', '-0.1', '+3.14', '4.', '-.9', '2e10', '-90E3', '3e+7', '+6e-1', '53.5e93', '-123.456e789'. " +
                  "The following are not valid: 'abc', '1a', '1e', 'e3', '99e2.5', '--6', '-+3', '95a54e53'.",
                
                Solution = @"public class Solution
                {
                    public bool IsNumber(string s)
                    {
                        s = s.Trim(); // Remove leading and trailing whitespace
                        bool hasNum = false, hasDot = false, hasE = false;

                        for (int i = 0; i < s.Length; i++)
                        {
                            char c = s[i];

                            if (char.IsDigit(c))
                            {
                                hasNum = true;
                            }
                            else if (c == '.')
                            {
                                // A dot is invalid if we've already seen one or if there's an 'e' before it
                                if (hasDot || hasE)
                                    return false;
                                hasDot = true;
                            }
                            else if (c == 'e' || c == 'E')
                            {
                                // 'e' is invalid if we've already seen it or if there's no number before it
                                if (hasE || !hasNum)
                                    return false;
                                hasE = true;
                                hasNum = false; // Reset hasNum to ensure there's a number after 'e'
                            }
                            else if (c == '+' || c == '-')
                            {
                                // A sign is valid only at the start or right after an 'e'
                                if (i > 0 && s[i - 1] != 'e' && s[i - 1] != 'E')
                                    return false;
                            }
                            else
                            {
                                // Any other character is invalid
                                return false;
                            }
                        }

                        return hasNum; // Ensure there's a valid number at the end
                    }
                }",

                Difficulty = "Hard",
                TestCases = new List<TestCase>
                {
                    new TestCase
                    {
                        ProblemOrder = 1,
                        Input = "\"2\"",
                        Output = "true",
                        Explanation = "'2' is a valid integer.",
                    },

                    new TestCase
                    {
                        ProblemOrder = 2,
                        Input = "\"1e\"",
                        Output = "false",
                        Explanation = "'1e' is invalid because it lacks a number after 'e'.",
                    },

                }
            }


        };

        /// <summary>
        /// Method to get all the LeetCode problems
        /// </summary>
        /// <returns>A list of LeetCode problems</returns>
        public List<LeetCodeProblem> GetAllProblems()
        {
            return ProblemList;
        }

        /// <summary>
        /// Method to get a specific LeetCode problem by its ID
        /// </summary>
        /// <param name="ProblemId">Unique ID of the selected problem</param>
        /// <returns>The LeetCodeProblem object of the problem with according ID</returns>
        public LeetCodeProblem GetProblemById(int ProblemId)
        {
            return ProblemList.FirstOrDefault(problem => problem.ID == ProblemId);
        }
    }
}