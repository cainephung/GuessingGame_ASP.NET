// Filename:	Win.aspx.cs
// Author:		Caine Phung
// Date:		Nov 12, 2022
// Description:	Win page.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CP_HiLo_A5
{
    public partial class Win : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            HttpCookie cookie = Request.Cookies["userName"];
            string name = cookie["name"];
            buttonPrompt.Text = "Hello " + name + ", YOU WIN !!!";      
        
        }



        /*
        * METHOD : default_Click
        * DESCRIPTION : retry
        * PARAMETERS : none
        */
        protected void reset_Click(object sender, EventArgs e)
        {
            // reset all cookies except user name
            string[] myCookies = Request.Cookies.AllKeys;

            foreach (string cookie in myCookies)
            {
                if (!myCookies.Contains("userName"))
                {

                    Response.Cookies[cookie].Value = null;
                }

            }

            Response.Redirect("Max.aspx");
        }
    }
}