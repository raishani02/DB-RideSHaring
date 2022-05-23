using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RideSharing.DAL;
namespace RideSharing
{
    public partial class DriverCarDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_car_detail(object sender, EventArgs e)
        {
            String contact_number = Session["Contact_number"].ToString();
            String car_id = TextBox1.Text;
            String color = TextBox2.Text;

            int capacity = int.Parse(TextBox4.Text);
            string maker = TextBox3.Text;

            String new_email = TextBox3.Text;


            myDAL objmyDal = new myDAL();
            int found = 0;
            found = objmyDal.Add_car_detail(contact_number, car_id, color, capacity, maker);
            if (found == 0)
            {
                //user not exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User did not exists')", true);

            }
            else if (found == 1)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Car Detail is Added')", true);
                Response.Redirect("Login.aspx");
            }
        }
    }
}