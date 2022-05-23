function submitformlogin() {
    int Found = 0;
    DataSet ds = new DataSet();
    SqlConnection con = new SqlConnection(connString);
    con.Open();
    SqlCommand cmd;
    try {
        cmd = new SqlCommand("USER_LOGIN ", con); //name of your procedure
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@Contact_Number", SqlDbType.VarChar, 20);
        cmd.Parameters.Add("@Password", SqlDbType.VarChar, 10);
        cmd.Parameters.Add("@type", SqlDbType.VarChar, 10);
        cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

        // set parameter values
        cmd.Parameters["@Contact_Number"].Value = document.getElementById('ContactNo').value;
        cmd.Parameters["@Password"].Value = document.getElementById('Password').value;
        cmd.Parameters["@type"].Value = document.getElementById('DropDownList1').value;
        cmd.ExecuteNonQuery();

        // read output value 
        Found = Convert.ToInt32(cmd.Parameters["@Found"].Value); //convert to output parameter to interger format

        if (Found == 1) {
            using(SqlDataAdapter da = new SqlDataAdapter(cmd))

            {
                da.Fill(ds);

            }

            DT = ds.Tables[0];

        }


        con.Close();


    }
    catch (SqlException ex)
    {
        Console.WriteLine("SQL Error" + ex.Message.ToString());

    }
            finally {
        con.Close();
    }

    return Found;


}
function submitformsignup() {
    //var medium1 = document.getElementById('Starting_Location').value; //dropdown list
    //var medium2 = document.getElementById('Ending_Location').value; //dropdown list  
    //var medium3 = document.getElementById('Number_of_Passengers').value; //dropdown list  
    //var temp = 123;
    //document.getElementById('TextBox4').value = temp;
    //temp /= parseInt(medium3);
    //document.getElementById('TextBox1').value = temp;

}