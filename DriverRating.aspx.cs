using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RideSharing.DAL;
using System.Data;
namespace RideSharing
{
    public partial class DriverRating : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitformRating(object sender, EventArgs e)
        {
           // int rating = Convert.ToInt32(Session["Count"].ToString());
            String DriverContact=TextBox1.Text;
            String PassengerContact= Session["Contact_Number"].ToString();
            String Comments =TextBox2.Text;
            int rating = Convert.ToInt32(list1.Text);
            myDAL objmyDal = new myDAL();
            int found = 0;
            found = objmyDal.checkReviews(rating, Comments, DriverContact, PassengerContact);
            if (found == 0)
            {
                //user not exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('NO ride exist for ratings')", true);

            }
            else if (found == 1)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ratings Added')", true);

            }
            else if (found == 2)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Enter the correct driver number to rate drive')", true);

            }
        }
    }
}