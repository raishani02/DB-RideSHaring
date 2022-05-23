using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RideSharing.DAL;

namespace RideSharing
{
    public partial class PassengerEditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void update_email(object sender, EventArgs e)
        {
            
            String contact_number = Session["Contact_number"].ToString();
            String new_email = TextBox3.Text;


            myDAL objmyDal = new myDAL();
            int found = 0;
            found = objmyDal.update_email(contact_number,new_email);
            if (found == 0)
            {
                //user not exist
               // TextBox3.Text = "";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User did not exists')", true);
                
            }
            else if (found == 1)
            {
                //user exist
               // TextBox3.Text = "";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Email is updated')", true);
                
            }          
        }
        protected void update_password(object sender, EventArgs e)
        {

            String contact_number = Session["Contact_number"].ToString();
            String password = TextBox2.Text;


            myDAL objmyDal = new myDAL();
            int found = 0;
            found = objmyDal.update_password(contact_number, password);
            if (found == 0)
            {
                //user not exist
                //TextBox2.Text = "";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User did not exists')", true);
                
            }
            else if (found == 1)
            {
                //user exist
                //TextBox2.Text = "";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Password updated Successfully')", true);
                
                Response.Redirect("Login.aspx");
            }
        }
        protected void update_username(object sender, EventArgs e)
        {

            String contact_number = Session["Contact_number"].ToString();
            String new_name = TextBox1.Text;


            myDAL objmyDal = new myDAL();
            int found = 0;
            found = objmyDal.update_username(contact_number, new_name);
            if (found == 0)
            {
                //user not exist
                //TextBox1.Text = "";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User did not exists')", true);
                
            }
            else if (found == 1)
            {
                //user exist
               // TextBox1.Text = "";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('UserName updated Successfully')", true);
                
            }
        }
    }
}