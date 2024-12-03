using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// This class is used to store the information of a LeetCode problems.
// Have a list named _problems to store the problems.
// Have a method named GetAllProblems to return the list of problems.
// Have a method named GetProblemById to return a problem by its id.
namespace HackArena.Models
{
    public class LeetCodeService
    {
        public readonly List<LeetCodeProblem> ProblemList = new List<LeetCodeProblem>
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
                TestCases = new List<TestCase>
                {
                    new TestCase
                    {
                        TestCaseId = 11,
                        ProblemOrder = 1,
                        Input = "4",
                        Output = "2",
                        Explanation = "There are two distinct solutions for a 4x4 chessboard.",
                    },

                    new TestCase
                    {
                        TestCaseId = 22,
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
                Title = "Empty",
                Description = "Empty",
                Solution = "Empty",
                TestCases = new List<TestCase>
                {
                    new TestCase
                    {
                        TestCaseId = 33,
                        ProblemOrder = 1,
                        Input = "Empty for now",
                        Output = "Empty for now",
                        Explanation = "Empty for now",
                    },

                    new TestCase
                    {
                        TestCaseId = 44,
                        ProblemOrder = 2,
                        Input = "Empty for now",
                        Output = "Empty for now",
                        Explanation = "Empty for now",
                    },

                }
            },

            new LeetCodeProblem
            {
                ID = 3,
                Title = "Empty",
                Description = "Empty",
                Solution = "Empty",
                TestCases = new List<TestCase>
                {
                    new TestCase
                    {
                        TestCaseId = 55,
                        ProblemOrder = 1,
                        Input = "Empty for now",
                        Output = "Empty for now",
                        Explanation = "Empty for now",
                    },

                    new TestCase
                    {
                        TestCaseId = 66,
                        ProblemOrder = 2,
                        Input = "Empty for now",
                        Output = "Empty for now",
                        Explanation = "Empty for now",
                    },

                }
            },

            new LeetCodeProblem
            {
                ID = 4,
                Title = "Empty",
                Description = "Empty",
                Solution = "Empty",
                TestCases = new List<TestCase>
                {
                    new TestCase
                    {
                        TestCaseId = 77,
                        ProblemOrder = 1,
                        Input = "Empty for now",
                        Output = "Empty for now",
                        Explanation = "Empty for now",
                    },

                    new TestCase
                    {
                        TestCaseId = 88,
                        ProblemOrder = 2,
                        Input = "Empty for now",
                        Output = "Empty for now",
                        Explanation = "Empty for now",
                    },

                }
            }


        };

        public List<LeetCodeProblem> GetAllProblems()
        {
            return ProblemList;
        }

        public LeetCodeProblem GetProblemById(int ProblemId)
        {
            return ProblemList.FirstOrDefault(problem => problem.ID == ProblemId);
        }
    }
}