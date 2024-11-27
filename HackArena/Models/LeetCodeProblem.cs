using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// This class is used to store the information of a LeetCode problem
// id, title, difficulty, 
namespace HackArena.Models
{
    public class LeetCodeProblem
    {
            public int ID { get; set; }
            public string Title { get; set; } // Problem title
            public string Description { get; set; } // Problem description
            public string Solution { get; set; } // Solution code (if needed as a string)
            public List<TestCase> TestCases { get; set; }


            /*public LeetCodeProblem(int ID, string title, string description, string solution, List<TestCase> TestCases)
            {
                ID = ID;
                Title = title;
                Description = description;
                Solution = solution;
                TestCases = TestCases;
            }*/
    }
}