/*
    * Name: Enjoyable Egrets
    * Email: vopq@mail.uc.edu, cadetce@mail.uc.edu, yemaneag@mail.uc.edu, hossaizn@mail.uc.edu
    * Assignment Number: Final Project
    * Due Date: Dec 5th, 2024
    * Course #/Section: IS 3050 - 002
    * Semester/Year: Fall 2024
    * Brief Description of the assignment: Build a website that shows a list of LeetCode problems and allows users to invoke the solutions.
    * Citations: ChatGPT; https://learn.microsoft.com/en-us/dotnet/api/system.web.ui.webcontrols?view=netframework-4.8.1 
    *Anything else that's relevant: N/A
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// This class is used to store the information of a LeetCode problem
namespace HackArena.Models
{
    public class LeetCodeProblem
    {
            public int ID { get; set; }                     // Problem ID
            public string Title { get; set; }               // Problem title
            public string Description { get; set; }         // Problem description
            public string Solution { get; set; }            // Solution code 
            public string Difficulty { get; set; }          // Problem difficulty
            public List<TestCase> TestCases { get; set; }   // List of test cases
    }
}