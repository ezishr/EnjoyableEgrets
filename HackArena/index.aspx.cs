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


using System.Security.Cryptography;
using System.Xml.Linq;
using HackArena.Models;
using System;
using System.Collections.Generic;

namespace HackArena
{
    public partial class index : System.Web.UI.Page
    {

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
