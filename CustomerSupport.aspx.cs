using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RideSharing.DAL;
namespace RideSharing
{
    public partial class CustomerSupport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void change_page(object sender, EventArgs e)
        {
            Response.Redirect("HomePassenger.aspx");
        }
        protected void complain(object sender, EventArgs e)
        {
            String p_contact_number = Session["Contact_number"].ToString();
            String d_contact = TextBox3.Text;
            String complain = TextBox2.Text;
            myDAL obj = new myDAL();
            int found = obj.complain(p_contact_number, d_contact, complain);
            if (found == 0)
            {
                //user not exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('NO complete ride exists with ratings to give complain')", true);
            }
            else if (found == 1)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Complain Added Successfully')", true);
            }
            else if (found == 2)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Complain is already exists')", true);
            }
        }


    }
}