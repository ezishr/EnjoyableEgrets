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
                gvProblems.DataSource = leetCodeService.GetAllProblems();
                gvProblems.DataBind();
            }
        }
        
    }
}