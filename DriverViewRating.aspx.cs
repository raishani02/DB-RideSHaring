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
    public partial class DriverViewRating : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewRatings(sender, e);
        }
        protected void viewRatings(object sender, EventArgs e)
        {
            String contact_number = Session["Contact_number"].ToString();


            myDAL objmyDal = new myDAL();
           
            DataTable DT = new DataTable();
            //found = objmyDal.Add_car_detail(contact_number, car_id, color, capacity, maker);
            DT=objmyDal.view_Ratings(contact_number);
           
            GridView1.DataSource = DT;//seting data source for this Grid
            GridView1.DataBind();
        }
    }
}