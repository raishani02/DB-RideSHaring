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
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitformsignup(object sender, EventArgs e)
        {
            String a = us.Text, b = em.Text, c = gnd.Text, d = Contact.Text, f = pass.Text, g = DropDownList1.Text;

            myDAL objmyDal = new myDAL();
            int found = 0;
            found = objmyDal.checksignup(a,b,c,d,f,g);

            Session["Contact_number"] = d;
            Session["Password"] = f;
            Session["type"] = g;
            if (found == 0)
            {
                //user not exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Values Not Be NULL')", true);

            }
            else if (found == 1)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User Added')", true);
                if(g=="Passenger")
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Redirect("DriverCarDetail.aspx");
                }
               
            }
            else if (found == 2)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User is Already Exists')", true);


            }




        }
    }
}