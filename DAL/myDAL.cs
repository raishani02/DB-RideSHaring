using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace RideSharing.DAL
{
    public class myDAL
    {
        private static readonly string connString =
        System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionName"].ConnectionString;
        public int checklogin(String _Cont,String _Pass,String _Type)
        {

            int Found = 0;
           // DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("USER_LOGIN ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Contact_Number", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@type", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@Contact_Number"].Value = _Cont;
                cmd.Parameters["@Password"].Value = _Pass;
                cmd.Parameters["@type"].Value = _Type;

                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format

           
                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        
        public int checksignup(String _a, String _b, String _c, String _d, String _f, String _g)
        {

            int Found = 0;
           // DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            //con.Close();
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("SignUp ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.Add("@u_name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@gender", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@Contact_Number", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@type_of_user", SqlDbType.VarChar, 10);

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@u_name"].Value = _a;
                cmd.Parameters["@email"].Value = _b;
                cmd.Parameters["@gender"].Value = _c;
                cmd.Parameters["@Contact_Number"].Value = _d;
                cmd.Parameters["@Password"].Value = _f;
                cmd.Parameters["@type_of_user"].Value = _g;

                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
       
        public DataTable checkprofile(String _Cont, String _Pass, String _Type,ref DataTable data)
        {

            
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
          
            try
            {
                cmd = new SqlCommand("Get_profile", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Contact_number", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@type", SqlDbType.VarChar, 10);
                //cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@Contact_number"].Value = _Cont;
                cmd.Parameters["@password"].Value = _Pass;
                cmd.Parameters["@type"].Value = _Type;
                cmd.ExecuteNonQuery();
                
                // read output value 
                //Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format
               
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }
               
            }
           catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                
            }
            finally
            {
                con.Close();
            }
            if(_Type=="Passenger")
            {
                DataTable DT = new DataTable();
                data = new DataTable();
                DT = ds.Tables[0];
                return DT;
            }
            else
            {
                DataTable DT = new DataTable();
                data = new DataTable();
                DT = ds.Tables[0];
                data = ds.Tables[1];
                return DT;
            }
            
            
        }
        public int update_email(String contact_number,String new_email)
        {

            int Found = 0;
            // DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            //con.Close();
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("update_email", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandType = CommandType.;
                cmd.Parameters.Add("@contact_number", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@new_email", SqlDbType.VarChar, 30);
                

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@contact_number"].Value =contact_number ;
                cmd.Parameters["@new_email"].Value = new_email;
               

                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        public int update_password(String contact_number, String new_password)
        {

            int Found = 0;
            // DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            //con.Close();
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("update_password", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@contact_number", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@new_password", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@contact_number"].Value = contact_number;
                cmd.Parameters["@new_password"].Value = new_password;


                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        public int update_username(String contact_number, String new_name)
        {

            int Found = 0;
            // DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            //con.Close();
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("update_username", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@contact_number", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@new_name", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@contact_number"].Value = contact_number;
                cmd.Parameters["@new_name"].Value = new_name;


                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        public int update_car_detail(String contact_number, String car_id,String color,int capacity,String maker)
        {

            int Found = 0;
            // DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            //con.Close();
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("update_car_detail", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Driver_contact_number", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@new_car_id", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@new_color", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@new_capacity", SqlDbType.Int);
                cmd.Parameters.Add("@new_maker", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@Driver_contact_number"].Value = contact_number;
                cmd.Parameters["@new_car_id"].Value = car_id;
                cmd.Parameters["@new_color"].Value = color;
                cmd.Parameters["@new_capacity"].Value = capacity;
                cmd.Parameters["@new_maker"].Value = maker;


                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        public int Add_car_detail(String contact_number, string car_id, string color, int capacity, string maker)
        {

            int Found = 0;
            // DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            //con.Close();
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Add_Car_detail", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Driver_contact_number", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@car_id", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@color", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@capacity", SqlDbType.Int);
                cmd.Parameters.Add("@maker", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@Driver_contact_number"].Value = contact_number;
                cmd.Parameters["@car_id"].Value = car_id;
                cmd.Parameters["@color"].Value = color;
                cmd.Parameters["@capacity"].Value = capacity;
                cmd.Parameters["@maker"].Value = maker;


                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        public DataTable history(String contact,String type)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("view_history", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@contact", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@type", SqlDbType.VarChar, 20);
                // cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@contact"].Value = contact;
                cmd.Parameters["@type"].Value = type;
                cmd.ExecuteNonQuery();

                // read output value 
                //Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }
            DataTable DT = new DataTable();
            DT = ds.Tables[0];
            return DT;
        }
        public DataTable view_Ratings(String contact)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("viewRatings", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@contact", SqlDbType.VarChar, 12);
               
                // cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@contact"].Value = contact;
                
                cmd.ExecuteNonQuery();

                // read output value 
                //Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }
            DataTable DT = new DataTable();
            DT = ds.Tables[0];
            return DT;

        }
        public int checkReviews(int ratings, String comments,String DriverContact,String PassengerContact)
        {
            int Found = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Give_Review", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Passenger_ContactNumber", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@Driver_contactNumber", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@Rating_Count", SqlDbType.Int);
                cmd.Parameters.Add("@Reviews", SqlDbType.VarChar, 8000);

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
               
                cmd.Parameters["@Passenger_ContactNumber"].Value = PassengerContact;  ///
                cmd.Parameters["@Driver_ContactNumber"].Value = DriverContact;  ////
                cmd.Parameters["@Rating_Count"].Value = ratings;
                cmd.Parameters["@Reviews"].Value = comments;

                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        public int Get_driver(String contact,String starting_loc,String ending_loc,int passengers,ref DataTable DT)
        {
            int Found = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("get_driver", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Passenger_Contact", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@Starting_location", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@Ending_location", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@Passengers", SqlDbType.Int);
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@Passenger_Contact"].Value = contact;
                cmd.Parameters["@Starting_location"].Value = starting_loc;
                cmd.Parameters["@Ending_location"].Value = ending_loc;
                cmd.Parameters["@Passengers"].Value = passengers;

                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }
            if(Found==1)
            {
                DT = new DataTable();
                DT = ds.Tables[0];
            }
           
            return Found;

        }
        public int Request_ride(String contact, String starting_loc, String ending_loc, int passengers)
        {
            int Found = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("request_ride", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Passenger_Contact", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@Starting_location", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@Ending_location", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@Passengers", SqlDbType.Int);
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@Passenger_Contact"].Value = contact;
                cmd.Parameters["@Starting_location"].Value = starting_loc;
                cmd.Parameters["@Ending_location"].Value = ending_loc;
                cmd.Parameters["@Passengers"].Value = passengers;

                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        public int Cancel_ride(String contact, String starting_loc, String ending_loc, int passengers)
        {
            int Found = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("cancel_ride", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Passenger_Contact", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@Starting_location", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@Ending_location", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@Passengers", SqlDbType.Int);
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@Passenger_Contact"].Value = contact;
                cmd.Parameters["@Starting_location"].Value = starting_loc;
                cmd.Parameters["@Ending_location"].Value = ending_loc;
                cmd.Parameters["@Passengers"].Value = passengers;

                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        public int post(String contact, String starting_loc, String ending_loc, int passengers)
        {
            int Found=0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("post_ride", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@contact", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@source", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@destination", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@available_passenger", SqlDbType.Int);
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@contact"].Value = contact;
                cmd.Parameters["@source"].Value = starting_loc;
                cmd.Parameters["@destination"].Value = ending_loc;
                cmd.Parameters["@available_passenger"].Value = passengers;

                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }
           
            return Found;

        }
        public DataTable car_detail(String contact)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("get_car_detail", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@contact", SqlDbType.VarChar, 12);

                // cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@contact"].Value = contact;

                cmd.ExecuteNonQuery();

                // read output value 
                //Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }
            DataTable DT = new DataTable();
            DT = ds.Tables[0];
            return DT;

        }
        public int Start_ride(String contact, String starting_loc, String ending_loc)
        {
            int Found = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("start_ride", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@driver_contact", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@starting_locatio", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@ending_location", SqlDbType.VarChar, 30);
               
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@driver_contact"].Value = contact;
                cmd.Parameters["@starting_locatio"].Value = starting_loc;
                cmd.Parameters["@ending_location"].Value = ending_loc;
                

                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        public int Complete_ride(String contact, String starting_loc, String ending_loc)
        {
            int Found = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("complete_ride", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@driver_contact", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@starting_locatio", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@ending_location", SqlDbType.VarChar, 30);

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@driver_contact"].Value = contact;
                cmd.Parameters["@starting_locatio"].Value = starting_loc;
                cmd.Parameters["@ending_location"].Value = ending_loc;


                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        public int complain(String p_conatct, String DriverContact, String complain)
        {
            int Found = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("add_complain", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@passenger_contact", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@driver_contact", SqlDbType.VarChar, 12);
                cmd.Parameters.Add("@complain", SqlDbType.VarChar,100);
                
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values

                cmd.Parameters["@passenger_contact"].Value = p_conatct;  ///
                cmd.Parameters["@driver_contact"].Value = DriverContact;  ////
                cmd.Parameters["@complain"].Value = complain;
                
                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@output"].Value); //convert to output parameter to interger format


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }

    }
}

