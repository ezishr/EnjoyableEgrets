using HackArena.Models;
using System;
using System.Collections.Generic;

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
                gvProblems.DataSource = leetCodeService.GetAllProblems();
                gvProblems.DataBind();

                TrendingCompaniesRepeater.DataSource = new List<string>
                {
                    "Google", "Microsoft", "Amazon", "Apple", "Meta", "NVIDIA", "Goldman Sachs", "Bloomberg", "LinkedIn", "Citadel", "Uber", "SalesForce", "Snap", "Atlassian", "Oracle", "TikTok"
                };
                TrendingCompaniesRepeater.DataBind();
            }
        }

    }
}