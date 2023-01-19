// Filename:	Default.aspx.cs
// Author:		Caine Phung
// Date:		Nov 12, 2022
// Description:	Default page.

using System;
using System.Collections.Generic;
using System.Reflection;            // needed for retrieving this page's viewState

using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CP_HiLo_A5
{
    public partial class Default : Page
    {


        protected void Page_Init(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }


        protected void Page_Unload(object sender, EventArgs e)
        {
        }

        
        
        
        /*
        * METHOD : default_Click
        * DESCRIPTION : create, send cookies and redirect to next page
        * PARAMETERS : none
        */

        protected void default_Click(object sender, EventArgs e)
        {

            // create cookie for userName
            HttpCookie cookie = new HttpCookie("userName");
            cookie["name"] = ioBox.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("Max.aspx");
        }



        public StateBag ReturnViewState()
        {
            return ViewState;
        }
    }
}