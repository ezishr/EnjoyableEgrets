using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HackArena.Models;

namespace HackArena
{
    public partial class index : System.Web.UI.Page
    {
        /* Declare the list of problems from LeetCodeService class*/
        LeetCodeService leetCodeService = new LeetCodeService();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                // Get the list of problems from the service
                List<LeetCodeProblem> problems = leetCodeService.GetAllProblems();

                // Bind the list of problems to the GridView
                ProblemGridView.DataSource = problems;
                ProblemGridView.DataBind();
            }
        }

        protected void ProblemGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewDetails")
            {
                // Get the problem ID from the command argument
                int problemId = Convert.ToInt32(e.CommandArgument);

                // Redirect to the ProblemDetails page with the selected problem ID
                Response.Redirect("ProblemDetails.aspx?id=" + problemId);
            }
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}