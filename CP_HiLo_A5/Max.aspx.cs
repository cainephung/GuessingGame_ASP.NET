// Filename:	Max.aspx.cs
// Author:		Caine Phung
// Date:		Nov 12, 2022
// Description:	Maxs page.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CP_HiLo_A5
{
    public partial class Max : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            HttpCookie cookie = Request.Cookies["userName"];
            string name = cookie["name"];
            buttonPrompt.Text = "Hello " + name + ", please enter a max number (integer):";      
        }




        /*
        * METHOD : Max_Click
        * DESCRIPTION : create, send cookies and redirect to next page
        * PARAMETERS : none
        */

        protected void max_Click(object sender, EventArgs e)
        {

            string minNumStr = "1";
            int minNum = Int32.Parse(minNumStr);
            int maxNum = Int32.Parse(ioBox.Text);
            Random random = new Random();

            int randomNum = random.Next(minNum, maxNum);
            string randomNumStr = randomNum.ToString();

            // create cookie
            HttpCookie cookie = new HttpCookie("maxNumber");
            cookie["name"] = ioBox.Text;
            cookie["min"] = minNumStr;
            cookie["max"] = ioBox.Text;
            cookie["random"] = randomNumStr;
            Response.Cookies.Add(cookie);
            Response.Redirect("Guess.aspx");
        }
    }
}