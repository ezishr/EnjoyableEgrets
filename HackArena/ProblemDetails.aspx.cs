﻿/*
    *Name: Enjoyable Egrets
    * Email: vopq @mail.uc.edu, cadetce @mail.uc.edu, yemaneag @mail.uc.edu, hossaizn @mail.uc.edu
    * Assignment Number: Final Project
    * Due Date: Dec 5th, 2024
    * Course #/Section: IS 3050 - 002
    * Semester/Year: Fall 2024
    * Brief Description of the assignment: Build a website that shows a list of LeetCode problems and allows users to invoke the solutions.
    * Citations: ChatGPT; https://learn.microsoft.com/en-us/dotnet/api/system.web.ui.webcontrols?view=netframework-4.8.1 
    *Anything else that's relevant: N/A
*/

using EnjoyableEgrets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnjoyableEgrets
{
    public partial class ProblemDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LeetCodeService leetCodeService = new LeetCodeService();

                // Get the problem ID from the query string
                if (int.TryParse(Request.QueryString["ID"], out int problemId))
                {
                    var problem = leetCodeService.GetProblemById(problemId);

                    if (problem != null)
                    {
                        // Populate the left column
                        lblProblemTitle.Text = $"Title: {problem.Title}";
                        lblProblemDescription.Text = "Description: <br />";
                        lblProblemDescription.Text += $"<span style='font-family: Roboto Mono, monospace; font-weight: normal'>{problem.Description}</span>";
                        lblProblemTestCase.Text = "Test Cases: <br />";
                        foreach (var testCase in problem.TestCases)
                        {
                            lblProblemTestCase.Text += $"<span style='font-family: Roboto Mono, monospace; font-weight: normal'><strong>Case:</strong> {testCase.ProblemOrder} </span><br />";
                            lblProblemTestCase.Text += $"<span style='font-family: Roboto Mono, monospace; font-weight: normal'><strong>Input:</strong> {testCase.Input} </span><br />";
                            lblProblemTestCase.Text += $"<span style='font-family: Roboto Mono, monospace; font-weight: normal'><strong>Output:</strong> {testCase.Output} </span><br />";
                            lblProblemTestCase.Text += $"<span style='font-family: Roboto Mono, monospace; font-weight: normal'><strong>Explanation:</strong> {testCase.Explanation} </span><br /><br />";
                        }
                    }
                }
            }
        }

        protected void btnShowSolution_Click(object sender, EventArgs e)
        {
            LeetCodeService leetCodeService = new LeetCodeService();

            // Get the problem ID from the query string
            if (int.TryParse(Request.QueryString["ID"], out int problemId))
            {
                var problem = leetCodeService.GetProblemById(problemId);

                if (problem != null)
                {
                    // Show the solution in the hidden textbox
                    txtActualSolution.Visible = true;
                    txtActualSolution.Text = problem.Solution;
                }
            }
        }
    }
}