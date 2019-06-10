using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGit
{
    public partial class Develop1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("This is develop1");
            Response.Write("This is Live Fix");
            Response.Write("This is Test Fix");
        }
    }
}