// Filename:	Guess.aspx.cs
// Author:		Caine Phung
// Date:		Nov 12, 2022
// Description:	Guess page.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CP_HiLo_A5
{
    public partial class Guess :Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            HttpCookie cookie = Request.Cookies["userName"];
            string name = cookie["name"];
            buttonPrompt.Text = "Hello " + name + ", please enter an integer for your guess:";
        }

        /*
        * METHOD : guess_Click
        * DESCRIPTION : validations
        * PARAMETERS : none
        */

        protected void guess_Click(object sender, EventArgs e)
        {

                HttpCookie cookie = Request.Cookies["maxNumber"];

                int max = Convert.ToInt32(cookie["max"]);

                int min = Convert.ToInt32(cookie["min"]);

               
                int random = Convert.ToInt32(cookie["random"]);

                string guessStr = ioBox.Text;
                int guess = Convert.ToInt32(guessStr);
                int upper = guess + 1;
                int lower = guess - 1;


                if ((guess > max) || (guess < min))
                {

                    Message.Text = "Out of range! The guess range is between " + min + " and " + max;
                }

                else if ((guess < random) && (guess >= min))
                {

                    min = upper;
                    Message.Text = "The guess range is now between " + min + " and " + max;
                    
                    //update cookie
                    cookie["min"] = min.ToString();
                    Response.Cookies.Add(cookie);
                }

                else if ((guess > random) && (guess <= max))
                {
                    max = lower;
                    Message.Text = "The guess range is now between " + min + " and " + max;

                    //update cookie
                    cookie["max"] = max.ToString();
                    Response.Cookies.Add(cookie);
                } 

                if (guess == random)
                {

                    Response.Redirect("Win.aspx");
                }

            }
        }
}

