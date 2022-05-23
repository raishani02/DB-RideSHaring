<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DriverChangeVehicle.aspx.cs" Inherits="RideSharing.DriverChangeVehicle" %>

<!DOCTYPE html>

<link rel="stylesheet" href="PassengerHome.css"/>
<link rel="stylesheet" href="customersupportstyle.css"/>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
    <title>| Update Vehicle</title>
    <link rel = "icon" href ="https://icon-library.com/images/transportation_transport_vehicles_mustang_car-512.png" type = "image/x-icon"/> 

        <!--  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" /> -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" />
    
    <!--CSS start for sidebar and layout-->
   
    <!--CSS End for sidebar and layout-->


</head>
 
<body>
    <form id="form1" runat="server">

        <!-- START: create cross(cancel and menu botton on  the sidebar and out of the sidebar-->
        <input type="checkbox" id="check" />
        <label for="check">
            <i class="fas fa-bars" id="btn"></i>
            <i class="fas fa-times" id="cancel"></i>
        </label>
        <!-- END: create cross(cancel and menu botton on  the sidebar and out of the sidebar-->

        <!--sidebar start-->
        <div class="sidebar">
            <header>
                <div class="text" >UserName and PIC</div>
            </header>
            <ul>
                <li>
                    <a href="DriverHome.aspx">
                        <i class="fas fa-home"></i><span> Home</span> 
                    </a>
                </li>
                <li>
                    <a href="DriverEditProfile.aspx">
                        <i class="fas fa-edit"></i> Edit Profile 
                    </a>
                </li>
                <li>
                    <a href="PostRide.aspx">
                        <i class="fas fa-person-booth"></i> Post Ride
                    </a>
                </li>
                <li>
                    <a href="DriverViewRating.aspx">
                        <i class="fas fa-star"></i> View Ratings
                    </a>
                </li>

                <li>
                    <a href="DriverHistory.aspx">
                        <i class="fas fa-history"></i> History 
                    </a>
                </li>
                 <li>
                    <a href="DriverChangeVehicle.aspx">
                        <i class="fas fa-adjust"></i> Update Vehicle 
                    </a>
                </li>
                <li>
                    <a href="Login.aspx">
                        <i class="fas fa-power-off"></i> Logout 
                    </a>
                </li>
            </ul>
        </div>
        <!-- sidebar end-->

        <!-- START: BackGround Image -->
        <section>

            <!--image path is given in css part of that class-->
            <header>
                <div class="text" >Ride <span>Sharing </span>|<span> Update Vehicle</span></div>
            </header>

            <!-- START: left side menu of logout -->
            <div class="right_area">
                <a href="Login" class="fas fa-power-off"></><span> Logout</span>
                </a>
            </div>
            <!-- END: left side menu of logout -->
            <center>
            <div class="Box1">
                
                Enter New Car ID: 
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br /><br />
                <!--Send guidance -->
                
                Enter New Car maker:
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br /><br />
               
                Enter New Color of Car:                        
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br /><br />
                 Enter New Car's Capacity:                        
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

                <br /><br />

                <!--Send complaint -->
                Update Vehicle:
                <asp:Button ID="Button2" OnClick="update_car_detail" runat="server" Text="Update"  />
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
