<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PassengerEditProfile.aspx.cs" Inherits="RideSharing.PassengerEditProfile" %>

<!DOCTYPE html>
<link rel="stylesheet" href="PassengerHome.css"/>
<link rel="stylesheet" href="customersupportstyle.css"/>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
    <title>| Edit Profile</title>
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
                    <a href="HomePassenger.aspx">
                        <i class="fas fa-home"></i><span> Home</span> 
                    </a>
                </li>
                <li>
                    <a href="PassengerEditProfile.aspx">
                        <i class="fas fa-edit"></i> Edit Profile 
                    </a>
                </li>
                <li>
                    <a href="RequestRide.aspx">
                        <i class="fas fa-person-booth"></i> Request Ride
                    </a>
                </li>
                <li>
                    <a href="DriverRating.aspx">
                        <i class="fas fa-star"></i> Give Ratings
                    </a>
                </li>

                <li>
                    <a href="#">
                        <i class="fas fa-history"></i> History 
                    </a>
                </li>
                <li>
                    <a href="CustomerSupport.aspx">
                        <i class="far fa-question-circle"></i> Custumer Support 
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
                <div class="text" >Ride <span>Sharing </span>|<span> Edit Profile</span></div>
            </header>

            <!-- START: left side menu of logout -->
            <div class="right_area">
                <a href="Login.aspx" class="fas fa-power-off"></><span> Logout</span>
                </a>
            </div>
            <!-- END: left side menu of logout -->
            <center>
            <div class="Box1">
                
                <br/><br/>
                Enter New User Name: 
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <br /><br />
                        <!--Send guidance -->
                        Update User Name:
                        <asp:Button ID="Button1" OnClick="update_username" runat="server" Text="update" />
                        <br /><br />
                        Enter New Email:
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <br /><br />
                        Update Email:
                        <asp:Button ID="Button3" onClick="update_email" runat="server" Text="Update"  />

                        <!-- Enter complaint -->
                        <br /><br />
                        Enter New Password: 
                       
                        <asp:TextBox ID="TextBox2" type="password" runat="server" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" required minlength="8"></asp:TextBox>

                        <br /><br />

                        <!--Send complaint -->
                        Update Password:
                        <asp:Button ID="Button2" runat="server" OnClick="update_password" Text="Update"  />
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

