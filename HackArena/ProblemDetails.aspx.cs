using HackArena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HackArena
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
                        lblProblemDescription.Text = $"Description: {problem.Description}";
                        lblProblemTestCase.Text = "<h3>TestCases:</h3>";
                        foreach (var testCase in problem.TestCases)
                        {
                            lblProblemTestCase.Text += $"<strong>Input:</strong> {testCase.Input}<br />";
                            lblProblemTestCase.Text += $"<strong>Output:</strong> {testCase.Output}<br />";
                            lblProblemTestCase.Text += $"<strong>Explanation:</strong> {testCase.Explanation}<br /><br />";
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