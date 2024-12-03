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
                Title = "Empty",
                Description = "Empty",
                Solution = "Empty",
                Difficulty = "Easy",
                TestCases = new List<TestCase>
                {
                    new TestCase
                    {
                        TestCaseId = 1,
                        ProblemOrder = 1,
                        Input = "Empty for now",
                        Output = "Empty for now",
                        Explanation = "Empty for now",
                    },

                    new TestCase
                    {
                        TestCaseId = 2,
                        ProblemOrder = 2,
                        Input = "Empty for now",
                        Output = "Empty for now",
                        Explanation = "Empty for now",
                    },

                }
            },

            new LeetCodeProblem
            {
                ID = 1,
                Title = "Empty",
                Description = "Empty",
                Solution = "Empty",
                TestCases = new List<TestCase>
                {
                    new TestCase
                    {
                        TestCaseId = 1,
                        ProblemOrder = 1,
                        Input = "Empty for now",
                        Output = "Empty for now",
                        Explanation = "Empty for now",
                    },

                    new TestCase
                    {
                        TestCaseId = 2,
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