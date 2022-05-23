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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitForm(object sender, EventArgs e)
        {
            String a = Cont.Text;
            String b = Pass.Text;
            String c = DropDownList1.Text;
            myDAL objmyDal = new myDAL();
            int found = 0;
            found = objmyDal.checklogin(a, b, c);
            if (found == 0)
            {
                //user not exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Login Failed')", true);

            }
            else if (found == 1)
            { 
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Login Successfully')", true);
                Session["Contact_number"] = a;
                Session["Password"] = b;
                Session["type"] = c;
                if (c == "Passenger")
                {
                    Response.Redirect("HomePassenger.aspx");
                    
                }
                else
                {
                    Response.Redirect("DriverHome.aspx");
                }
            }

     


        }
    }
}