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
    public partial class DriverHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showpassprofile(sender, e);
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

        protected void showpassprofile(object sender, EventArgs e)
        {


            String contact = Session["Contact_number"].ToString();

            String password = Session["Password"].ToString();
            String type = Session["type"].ToString();

            DataTable DT = new DataTable();
            myDAL objmyDal = new myDAL();
            DataTable dt2 = new DataTable();
            DT = objmyDal.checkprofile(contact, password, type,ref dt2);
            DT = GenerateTransposedTable(DT);
            dt2 = GenerateTransposedTable(dt2);
            GridView1.DataSource = DT;//seting data source for this Grid
            GridView1.DataBind();
            GridView2.DataSource = dt2;//seting data source for this Grid
            GridView2.DataBind();
        }
    }
}