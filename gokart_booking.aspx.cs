using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5101_n01397262_assignment1_b_
{
    public partial class gokart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    formSummary.InnerHtml += "isvalid okay";
                    string driver_FirstName = driverFirstName.Text.ToString();
                    string driver_LastName = driverLastName.Text.ToString();
                    string driver_Email = driverEmail.Text.ToString();
                    string driver_Phone = driverPhone.Text.ToString();
                    int driver_Count = Convert.ToInt32(driverCount.Text);
                    string karting_Location = kartingLocation.SelectedValue.ToString();
                    string food_Requirement = foodRequirement.SelectedValue.ToString();
                    string Event_time = eventShift.SelectedValue.ToString();

                    formSummary.InnerHtml += "Driver's First Name: " + driverFirstName + "<br>";
                    formSummary.InnerHtml += "Driver's Last Name: " + driverLastName + "<br>";
                    formSummary.InnerHtml += "Driver's Email: " + driverEmail + "<br>";
                    formSummary.InnerHtml += "Driver's Phone Number: " + driverPhone + "<br>";
                    formSummary.InnerHtml += "Approx number of drivers: " + driverCount + "<br>";
                    formSummary.InnerHtml += "Karting Location: " + kartingLocation + "<br>";
                    formSummary.InnerHtml += "Food requirement: " + foodRequirement + "<br>";
                    formSummary.InnerHtml += "Event timing: " + eventShift + "<br>";
                    formSummary.InnerHtml += "Mode of Participation: " + participationMode + "<br>";
                }

            }
        }
    }
}