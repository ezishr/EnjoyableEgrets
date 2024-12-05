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

// This class is used to store the information of a test case of a problem.
namespace HackArena.Models
{
    public class TestCase
    {
        public int ProblemOrder { get; set; }       // TestCase order
        public string Input { get; set; }           // TestCase input of problem
        public string Output { get; set; }          // TestCase output of problem
        public string Explanation { get; set; }     // TestCase explanation of problem
    }
}
