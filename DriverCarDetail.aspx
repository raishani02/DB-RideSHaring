<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DriverCarDetail.aspx.cs" Inherits="RideSharing.DriverCarDetail" %>

<!DOCTYPE html>


<link rel="stylesheet" href="PassengerHome.css"/>
<link rel="stylesheet" href="customersupportstyle.css"/>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
    <title>| Add Vehicle</title>
    <link rel = "icon" href ="https://icon-library.com/images/transportation_transport_vehicles_mustang_car-512.png" type = "image/x-icon"/> 

        <!--  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" /> -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" />
    
    <!--CSS start for sidebar and layout-->
   
    <!--CSS End for sidebar and layout-->


</head>
 
<body>
    <form id="form1" runat="server">

        <!-- START: create cross(cancel and menu botton on  the sidebar and out of the sidebar-->
       
        <!-- END: create cross(cancel and menu botton on  the sidebar and out of the sidebar-->

       
        <section>

            <!--image path is given in css part of that class-->
            <header>
                <div class="text" >Ride <span>Sharing </span>|<span> Add Car Detail</span></div>
            </header>

            <!-- START: left side menu of logout -->
            <div class="right_area">
                <a href="Login.aspx" class="fas fa-power-off"></><span> Logout</span>
                </a>
            </div>
            <!-- END: left side menu of logout -->
            <center>
            <div class="Box1">
                
                Enter Car ID: 
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br /><br />
                <!--Send guidance -->
                
                Enter Car maker:
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br /><br />
               
                Enter Color of Car:                        
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br /><br />
                 Enter Car's Capacity:                        
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

                <br /><br />

                <!--Send complaint -->
                Add Vehicle:
                <asp:Button ID="Button2" OnClick="Add_car_detail" runat="server" Text="Add Detail"  />
                <br /><br />

                    <!--Reset everything -->
                
                
            </div>
             </center>
            <!--Start Edit profile form -->

            <!--Start Edit profile form -->
        </section>
        <!-- END: BackGround Image-->

    </form>
</body>
</html>