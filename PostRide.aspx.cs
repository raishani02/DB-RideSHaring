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
    public partial class PostRide : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private DataTable GenerateTransposedTable(DataTable inputTable)
        {
            DataTable outputTable = new DataTable();

            
            outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());

            foreach (DataRow inRow in inputTable.Rows)
            {
                string newColName = inRow[0].ToString();
                outputTable.Columns.Add(newColName);
            }

              
            for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
            {
                DataRow newRow = outputTable.NewRow();

                // First column is inputTable's Header row's second column
                newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();
                for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
                {
                    string colValue = inputTable.Rows[cCount][rCount].ToString();
                    newRow[cCount + 1] = colValue;
                }
                outputTable.Rows.Add(newRow);
            }

            return outputTable;
        }
        protected void post(object sender,EventArgs e)
        {
            String contact = Session["Contact_number"].ToString();
            String starting = Starting_Location.Text;
            String ending = Ending_Location.Text;
            String number = Number_of_Passengers.Text;
            int Passenger = Convert.ToInt32(number);
            
            myDAL objmyDal = new myDAL();

            int found = 0;
            found=objmyDal.post(contact, starting, ending, Passenger);
            if (found == 0)
            {
                //user not exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Post is not done')", true);
                
            }
            else if (found == 1)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Post is Done Successfully')", true);
            }
            else if (found == 2)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Path not found')", true);
                
            }
            else if (found == 3)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Driver is already posted a ride and passengers are assigned to him')", true);

            }
        }
        protected void Start_ride(object sender, EventArgs e)
        {
            String contact = Session["Contact_number"].ToString();
            String starting = Starting_Location.Text;
            String ending = Ending_Location.Text;
           

            myDAL objmyDal = new myDAL();

            int found = 0;
            found = objmyDal.Start_ride(contact, starting, ending);
            if (found == 0)
            {
                //user not exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('NO ride exists to start')", true);

            }
            else if (found == 1)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ride is Started Successfully')", true);
            }
            else if (found == 2)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Driver should have 4 passengers to start ride')", true);
            }
            else if (found == 3)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ride is already started')", true);
            }
        }
        protected void Complete_ride(object sender, EventArgs e)
        {
            String contact = Session["Contact_number"].ToString();
            String starting = Starting_Location.Text;
            String ending = Ending_Location.Text;


            myDAL objmyDal = new myDAL();

            int found = 0;
            found = objmyDal.Complete_ride(contact, starting, ending);
            if (found == 0)
            {
                //user not exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('NO ride exists to Complete')", true);

            }
            else if (found == 1)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ride Completed Successfully')", true);
               
            }
            else if (found == 2)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ride is not  started Yet')", true);
            }

        }
        protected void car_detail(object sender, EventArgs e)
        {
            String contact = Session["Contact_number"].ToString();
            
            myDAL objmyDal = new myDAL();
            DataTable DT = new DataTable();
            DataTable dt1 = new DataTable();
            DT = objmyDal.car_detail(contact);
            DT = GenerateTransposedTable(DT);
            GridView1.DataSource = DT;//seting data source for this Grid
            GridView1.DataBind();
        }
    }
}