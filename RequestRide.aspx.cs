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
    public partial class RequestRide : System.Web.UI.Page
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

        protected void cancel(object sender, EventArgs e)
        {
            String contact = Session["Contact_number"].ToString();
            String starting = Starting_Location.Text;
            String ending = Ending_Location.Text;
            int Passenger = Convert.ToInt32(Passengers.Text);
            myDAL objmyDal = new myDAL();
            int found = objmyDal.Cancel_ride(contact, starting, ending, Passenger);
            if (found == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Request not found')", true);
            }
            else if (found == 1)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Request cancelled Successfully')", true);
            }
            else if (found == 2)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ride is already started')", true);
            }
        }
        protected void request(object sender, EventArgs e)
        {

            String contact = Session["Contact_number"].ToString();
            String starting = Starting_Location.Text;
            String ending = Ending_Location.Text;
            int Passenger = Convert.ToInt32(Passengers.Text);
            myDAL objmyDal = new myDAL();
            int found = objmyDal.Request_ride(contact, starting, ending, Passenger);
            if (found == 0)
            {               
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Request did not added due to unavailabilty of driver on this Route')", true);
            }
            else if (found == 1)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Request added Successfully')", true);               
            }
            else if (found == 2)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Passenger is already requested for Ride')", true);
            }
        }
        protected void get_driver(object sender, EventArgs e)
        {

            String contact = Session["Contact_number"].ToString();
            String starting = Starting_Location.Text;
            String ending = Ending_Location.Text;
            int Passenger = Convert.ToInt32(Passengers.Text);
            DataTable DT = new DataTable();
            myDAL objmyDal = new myDAL();

            int found = objmyDal.Get_driver(contact, starting, ending, Passenger, ref DT);
            if (found == 0)
            {
                //user not exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Driver Not Found on this Route')", true);

            }
            else if (found == 1)
            {
                //user exist
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Driver found Successfully')", true);
                DT = GenerateTransposedTable(DT);
                GridView1.DataSource = DT;//seting data source for this Grid
                GridView1.DataBind();
            }
        }
    }
}